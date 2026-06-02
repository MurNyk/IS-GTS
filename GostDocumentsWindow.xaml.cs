<Window x:Class="IS_GTS.Windows.GostDocumentsWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Документы ГОСТ" Height="500" Width="700"
        WindowStartupLocation="CenterOwner"
        Background="#FFFFFFF6">

    <Grid Margin="10">
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
            <RowDefinition Height="Auto"/>
        </Grid.RowDefinitions>

        <!-- Заголовок -->
        <StackPanel Grid.Row="0">
            <TextBlock Text="Документы ГОСТ" FontSize="16" FontWeight="Bold" 
                       HorizontalAlignment="Center" Margin="0,0,0,5"/>
        </StackPanel>

        <!-- Поиск -->
        <Border Grid.Row="1" Background="#F5F5F5" CornerRadius="8" Padding="10" Margin="0,5,0,10">
            <StackPanel Orientation="Horizontal" HorizontalAlignment="Center">
                <TextBlock Text="Поиск:" VerticalAlignment="Center" Margin="0,0,10,0"/>
                <TextBox x:Name="SearchTextBox" Width="250" Height="30" 
                         TextChanged="SearchTextBox_TextChanged"/>
                <Button x:Name="ClearSearchButton" Content="Очистить" 
        Click="ClearSearchButton_Click" Width="70" Height="30" Margin="10,0,0,0"  Style="{StaticResource GrayRoundedButton}"/>

            </StackPanel>
        </Border>

        <!-- Список документов -->
        <ScrollViewer Grid.Row="2" VerticalScrollBarVisibility="Auto">
            <ItemsControl x:Name="DocumentsList">
                <ItemsControl.ItemTemplate>
                    <DataTemplate>
                        <Border BorderBrush="LightGray" BorderThickness="0,0,0,1" Padding="10" Margin="0,0,0,5">
                            <StackPanel>
                                <!-- Пояснение сверху (жирный) -->
                                <TextBlock Text="{Binding DisplayName}" FontSize="14" FontWeight="Bold"/>
                                <!-- Название файла снизу (серым) -->
                                <TextBlock Text="{Binding FileName}" FontSize="11" Foreground="Gray" Margin="0,5,0,0"/>
                                <TextBlock Text="{Binding FileSize}" FontSize="11" Foreground="Gray" Margin="0,2,0,5"/>
                                <StackPanel Orientation="Horizontal" Margin="0,5,0,0">
                                    <Button Content="Открыть" Click="OpenFile_Click" 
                                            Tag="{Binding FullPath}" Width="80" Margin="0,0,10,0"/>
                                    <Button Content="Скачать" Click="DownloadFile_Click" 
                                            Tag="{Binding FullPath}" Width="80"/>
                                </StackPanel>
                            </StackPanel>
                        </Border>
                    </DataTemplate>
                </ItemsControl.ItemTemplate>
            </ItemsControl>
        </ScrollViewer>

        <!-- Кнопки -->
        <Border Grid.Row="3" Background="White" BorderBrush="LightGray" BorderThickness="0,1,0,0" Padding="10">
            <StackPanel Orientation="Horizontal" HorizontalAlignment="Center">
                <Button Content="Закрыть" Click="CloseButton_Click" 
        Width="80" Height="32" Margin="5" Padding="5"  Style="{StaticResource GrayRoundedButton}"/>

            </StackPanel>
        </Border>
    </Grid>
</Window>