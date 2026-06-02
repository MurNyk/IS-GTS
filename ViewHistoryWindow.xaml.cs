<Window x:Class="IS_GTS.Windows.ViewHistoryWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:IS_GTS.Windows"
        mc:Ignorable="d"
        WindowStartupLocation="CenterScreen"
        Title="История просмотра" Height="450" Width="800" Background="#FFFFFFF6">
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
            <RowDefinition Height="Auto"/>
        </Grid.RowDefinitions>

        <Grid Grid.Row="0" Margin="10">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="Auto"/>
                <ColumnDefinition Width="*"/>
            </Grid.ColumnDefinitions>

            <Button Grid.Column="0" Content="Назад" x:Name="BackButton" Width="70" Height="30" Margin="10,0,0,0" Click="BackButton_Click"
        Style="{StaticResource GrayRoundedButton}"/>
            <TextBlock Grid.Column="1" Text="История просмотра" HorizontalAlignment="Center"  FontSize="16" FontWeight="Bold" VerticalAlignment="Center"/>
        </Grid>

        <Grid Grid.Row="1">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="Auto"/>
                <ColumnDefinition Width="*"/>
            </Grid.ColumnDefinitions>

            <StackPanel Orientation="Horizontal" Grid.Column="0" Margin="10,0,0,0">
                <Label Content="Выберите период:"/>
                <DatePicker x:Name="HistoryDatePicker" SelectedDateChanged="HistoryDatePicker_SelectedDateChanged"/>
            </StackPanel>
            <StackPanel Orientation="Horizontal" Grid.Column="1" Margin="270,0,0,0">
                <Label Content="Поиск:"/>
                <TextBox Width="120" x:Name="SearchTextBox" TextChanged="SearchTextBox_TextChanged" />
                <Button Content="Найти" x:Name="SearchButton" Width="70" Click="SearchButton_Click" Style="{StaticResource RoundedButton}"/>
            </StackPanel>
        </Grid>

        <DataGrid x:Name="HistoryDataGrid" Grid.Row="2" Margin="10" AutoGenerateColumns="False" CanUserAddRows="False" IsReadOnly="True">
            <DataGrid.Columns>
                <DataGridTextColumn Header="Дата/время просмотра" 
                            Binding="{Binding VisitDateTime, StringFormat='dd.MM.yyyy HH:mm'}" 
                            Width="150"/>
                <DataGridTextColumn Header="ГОСТ" 
                            Binding="{Binding GostNumber}" 
                            Width="150"/>
                <DataGridTextColumn Header="Название элемента" 
                            Binding="{Binding ProductName}" 
                            Width="200"/>
                <DataGridTextColumn Header="Категория" 
                            Binding="{Binding CategoryName}" 
                            Width="150"/>
                <DataGridTextColumn Header="Материал" 
                            Binding="{Binding MaterialName}" 
                            Width="150"/>
                <DataGridTextColumn Header="Поисковый запрос" 
                            Binding="{Binding SearchQuery}" 
                            Width="200"/>
            </DataGrid.Columns>
        </DataGrid>
        <StackPanel Orientation="Horizontal" Grid.Row="3" HorizontalAlignment="Right" Margin="0,0,10,10">
            <Button Content="Очистить историю" Width="120" Height="35" x:Name="ClearHistoryButton" Click="ClearHistoryButton_Click"
 Style="{StaticResource GrayRoundedButton}"/>
        </StackPanel>
        
    </Grid>
</Window>
