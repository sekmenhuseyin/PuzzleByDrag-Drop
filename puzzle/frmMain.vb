Public Class frmMain
    Dim SelectedPicture As Bitmap : Dim GameTime As Integer : Dim ArrayImages As New ArrayList : Dim GamePicsQueue(,) As Integer
    Dim Rotatable As Boolean = False : Dim RowCount, ColCount As Integer : Dim DraggedPB As Label : Dim FileSave As String = "PuzzleSaves.sav"
    Private Sub tsmiNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsmiNew.Click
        'ilk önce istenen resmi seçilir
        fdOpen.Filter = "Supported picture types|*.bmp;*.jpg;*.jpeg;*.png" : Dim DidWork As Integer = fdOpen.ShowDialog()
        If DidWork <> DialogResult.Cancel Then SelectedPicture = Bitmap.FromFile(fdOpen.FileName) Else Exit Sub
        'önceki resmi kutuları ve resim dizisi temizlenir ve yenileri oluşturulur
        PboxSelected.BackgroundImage = SelectedPicture : Call CreateNewGame()
    End Sub
    Private Sub tsmiOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsmiOpen.Click
        'open saved games
        If IO.File.Exists(FileSave) = True Then
            Dim objReader2 As New IO.StreamReader(FileSave)
            Do While objReader2.Peek() <> -1
                objReader2.ReadLine()
            Loop
            objReader2.Close()
        Else
            MsgBox("There are no saved games.")
        End If
    End Sub
    Private Sub tsmiSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsmiSave.Click
        'save an unfinished game
        Dim objWriter As New IO.StreamWriter(FileSave, False) 'true is append yapar
        objWriter.WriteLine(GameTime.ToString)
        objWriter.WriteLine(Rotatable.ToString)
        objWriter.WriteLine(ColCount.ToString)
        objWriter.WriteLine(RowCount.ToString)
        objWriter.WriteLine(SelectedPicture.ToString) 'burası hatalı. ya resmi kopyala ya da burda sadece resmin yolu olsun...
        objWriter.Close()
    End Sub
    Private Sub tsmiExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsmiExit.Click
        Me.Close() 'exit game
    End Sub
    Private Sub ChangeGameLevel(ByVal sender As Object, ByVal e As EventArgs) Handles tsmiLevel1.Click, tsmiLevel2.Click, tsmiLevel3.Click, tsmiLevel4.Click, tsmiLevel5.Click
        tsmiLevel1.Checked = False : tsmiLevel2.Checked = False : tsmiLevel3.Checked = False : tsmiLevel4.Checked = False : tsmiLevel5.Checked = False
        Select Case sender.ToString
            Case "Level 1" : tsmiLevel1.Checked = True : RowCount = 3 : ColCount = 3
            Case "Level 2" : tsmiLevel2.Checked = True : RowCount = 4 : ColCount = 4
            Case "Level 3" : tsmiLevel3.Checked = True : RowCount = 5 : ColCount = 5
            Case "Level 4" : tsmiLevel4.Checked = True : RowCount = 6 : ColCount = 6
            Case "Level 5" : tsmiLevel5.Checked = True : RowCount = 7 : ColCount = 7
        End Select
        tsmiLevel.Text = sender.ToString : Call CreateNewGame()
    End Sub
    Private Sub tsmiRotate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsmiRotate.Click
        If tsmiRotate.Checked = False Then tsmiRotate.Checked = True : Rotatable = True Else tsmiRotate.Checked = False : Rotatable = False
        Call CreateNewGame()
    End Sub
    Private Sub tsmiShowHint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsmiShowHint.Click
        If SelectedPicture Is Nothing Then Exit Sub
        If tsmiShowHint.Text = "Show Hint" Then PboxSelected.Visible = True : tsmiShowHint.Text = "Hide Hint" Else PboxSelected.Visible = False : tsmiShowHint.Text = "Show Hint"
    End Sub
    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ChangeGameLevel(tsmiLevel1, e)
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        Dim GameMin As String = Math.Floor(Convert.ToDouble(GameTime / 60)).ToString.PadLeft(2, "0")
        Dim GameSec As String = Math.Floor(Convert.ToDouble(GameTime Mod 60)).ToString.PadLeft(2, "0")
        lblStatus.Text = "Your time: " + GameMin + ":" + GameSec : GameTime += 1
    End Sub
    Private Sub CreateNewGame()
        Call ClearImages() : If SelectedPicture Is Nothing Then lblStatus.Text = "Select a picture to start" Else Call CreateImages()
        PboxSelected.SetBounds(10, 40, ColCount * 90 - 10, RowCount * 90 - 10) 'seçilen resim bir kutuya atılır daha sonra göstermek için
    End Sub
#Region "Image Procedures"
    Private Sub ClearImages()

        For i = 0 To Me.Controls.Count
            Try
                If Me.Controls(i).Name = "GamePictureBtn" Then Me.Controls.Remove(Me.Controls(i)) : i -= 1
            Catch ex As Exception
                Exit For
            End Try
        Next 'değikenler temizleniyor ve zaman sıfırlanıyor...
        PboxSelected.Image = Nothing : Timer1.Enabled = False : GameTime = 0 : ArrayImages.Clear() : If tsmiShowHint.Text = "Hide Hint" Then tsmiShowHint_Click(tsmiShowHint, EventArgs.Empty)
    End Sub
    Private Sub CreateImages()
        Dim GamePictureBtn As Label : Dim tmp As Integer = 0 : Dim yatay, dikey, i, j, k As Integer : Dim GamePics(ColCount * RowCount - 1) As Bitmap : ReDim GamePicsQueue(ColCount * RowCount - 1, 1)
        Dim tmpPicture As Bitmap = ResizeImage(SelectedPicture, ColCount / SelectedPicture.Width * 80, RowCount / SelectedPicture.Height * 80)
        Try 'seçilen resim 80x80 parçalara bölünür ve parçalar bir değişken diziye aktarılır
            For k = 0 To (ColCount * RowCount - 1)
                Dim tmpNewPicture As New Bitmap(80, 80)
                For i = 0 To 79
                    For j = 0 To 79
                        tmpNewPicture.SetPixel(i, j, tmpPicture.GetPixel(i + yatay, j + dikey))
                    Next
                Next
                GamePics(k) = tmpNewPicture
                ArrayImages.Add(tmpNewPicture) : yatay += 80 : If yatay = ColCount * 80 Then yatay = 0 : dikey += 80 'sayfada maksimum sütün sayısına göre genişliği geçmişse
            Next
        Catch ex As Exception 'birşey olur da hata yaparsa program
            MsgBox("Choose a different picture!", , "Error opening picture") : Exit Sub
        End Try
        Shuffle(ArrayImages, k, 7) 'dizi karıştırılır
        For k = 0 To (ColCount * RowCount - 1)
            For i = 0 To (ColCount * RowCount - 1)
                If ArrayImages(k).Equals(GamePics(i)) Then GamePicsQueue(k, 0) = i : GamePicsQueue(k, 1) = 0 : Exit For
            Next
        Next
        For i = 0 To RowCount - 1 'dizideki eleman sayısınca picturebox oluşturulur ve içlerine resimler yapıştırılır
            For j = 0 To ColCount - 1 'istenilen sıra ve sütun sayısına göre picturebox oluşturuyor
                GamePictureBtn = New Label : GamePictureBtn.Parent = Me : GamePictureBtn.Visible = True : GamePictureBtn.AllowDrop = True
                GamePictureBtn.Name = "GamePictureBtn" : GamePictureBtn.BorderStyle = BorderStyle.Fixed3D : GamePictureBtn.Tag = tmp
                GamePictureBtn.SetBounds(90 * j + 10, 90 * i + 40, 80, 80) : GamePictureBtn.Image = ArrayImages(tmp) : tmp += 1
                If Rotatable = True Then RotateImages(GamePictureBtn) 'döndürülsün seçilmişse rastgele resimleri döndürür
                AddHandler GamePictureBtn.MouseMove, AddressOf GamePictures_MouseMove 'pictureboxların eventleri
                AddHandler GamePictureBtn.DragDrop, AddressOf GamePictures_DragDrop 'pictureboxların eventleri
                AddHandler GamePictureBtn.DragOver, AddressOf GamePictures_DragOver 'pictureboxların eventleri
                AddHandler GamePictureBtn.DoubleClick, AddressOf GamePictures_DoubleClick 'pictureboxların eventleri
            Next j
        Next i
        Me.Width = ColCount * 90 + 30 : Me.Height = RowCount * 90 + 100 : Timer1.Enabled = True : Call Timer1_Tick(tsmiLevel1, EventArgs.Empty) 'formun büyüklüğü düzeltiliyor
    End Sub
    Private Sub RotateImages(ByVal DestinationPictureBox As Label, Optional ByVal RandomRotation As Boolean = True)
        Dim tmpDegree As Integer
        If RandomRotation = True Then tmpDegree = CInt(Rnd() * 4) Else tmpDegree = 1
        Select Case tmpDegree
            Case 1 : DestinationPictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
            Case 2 : DestinationPictureBox.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
            Case 3 : DestinationPictureBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
        End Select
        Dim x As Integer = GamePicsQueue(DestinationPictureBox.Tag, 1) + (tmpDegree * 90):If x = 360 Then x = 0
        GamePicsQueue(DestinationPictureBox.Tag, 1) = x : Me.Refresh()
    End Sub
    Private Function ResizeImage(ByVal PictureImage As Image, ByVal WidthScaleFactor As Single, ByVal HeightScaleFactor As Single) As Image
        Dim bmpDestination As New Bitmap(CInt(PictureImage.Width * WidthScaleFactor), CInt(PictureImage.Height * HeightScaleFactor))
        Dim GrDestination As Graphics = Graphics.FromImage(bmpDestination)
        GrDestination.DrawImage(PictureImage, 0, 0, bmpDestination.Width + 1, bmpDestination.Height + 1)
        Return bmpDestination
    End Function
    Private Sub Shuffle(ByRef arrayToBeShuffled As ArrayList, ByVal ArrayLength As Integer, ByVal numberOfTimesToShuffle As Integer)
        Dim rndPosition As New Random(DateTime.Now.Millisecond)
        For i As Integer = 1 To numberOfTimesToShuffle
            For i2 As Integer = 1 To ArrayLength
                swap(arrayToBeShuffled(rndPosition.Next(0, ArrayLength)), arrayToBeShuffled(rndPosition.Next(0, ArrayLength)))
            Next i2
        Next i
    End Sub
    Private Sub swap(ByRef arg1 As Object, ByRef arg2 As Object)
        Dim strTemp As Bitmap : strTemp = arg1 : arg1 = arg2 : arg2 = strTemp
    End Sub
    Private Sub CheckEndOfGame()
        For i = 0 To ColCount * RowCount - 1
            If GamePicsQueue(i, 0) <> i Then Exit Sub
            If GamePicsQueue(i, 1) <> 0 Then Exit Sub
        Next
        PboxSelected.Visible = True : MsgBox("bravo!") : Timer1.Enabled = False
    End Sub
#End Region
#Region "Image Label Events"
    Private Sub GamePictures_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
        If Rotatable = True Then RotateImages(sender, False)
    End Sub
    Private Sub GamePictures_MouseMove(ByVal sender As Object, ByVal e As Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If sender.Equals(Me) Then Exit Sub
        If e.Button = Windows.Forms.MouseButtons.Left Then DraggedPB = sender : sender.DoDragDrop(sender.image, DragDropEffects.All)
    End Sub
    Private Sub GamePictures_DragOver(ByVal sender As Object, ByVal e As Windows.Forms.DragEventArgs)
        e.Effect = DragDropEffects.Move
    End Sub
    Private Sub GamePictures_DragDrop(ByVal sender As Object, ByVal e As Windows.Forms.DragEventArgs)
        Dim tmpTag As String = GamePicsQueue(sender.tag, 0) : GamePicsQueue(sender.tag, 0) = GamePicsQueue(DraggedPB.Tag, 0)
        GamePicsQueue(DraggedPB.Tag, 0) = tmpTag : swap(sender.Image, DraggedPB.Image) : Me.Refresh() : Call CheckEndOfGame()
    End Sub
#End Region
End Class
