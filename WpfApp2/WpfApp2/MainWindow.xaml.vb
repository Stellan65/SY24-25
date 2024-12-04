Class MainWindow


    Private Sub PikaButton_Click(sender As Object, e As RoutedEventArgs) Handles PikaButton.Click
        Pika.Visibility = Visibility.Visible
        PikaStats.Visibility = Visibility.Visible
    End Sub

    Private Sub BulbButton_Click(sender As Object, e As RoutedEventArgs) Handles BulbButton.Click
        Bulb.Visibility = Visibility.Visible
        BulbStats.Visibility = Visibility.Visible
    End Sub

    Private Sub WaterButton_Click(sender As Object, e As RoutedEventArgs) Handles WaterButton.Click
        Water.Visibility = Visibility.Visible
        WaterStats.Visibility = Visibility.Visible
    End Sub
End Class
