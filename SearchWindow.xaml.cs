<Window x:Class="IS_GTS.Windows.SearchWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:IS_GTS.Windows"
        mc:Ignorable="d"
       Title="Справочник ГОСТ - Быстрый поиск" Height="650" Width="1000" WindowStartupLocation="CenterScreen" Background="#FFFFFFF6">
    <Grid Margin="10">
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <!-- Шапка -->
            <RowDefinition Height="Auto"/>
            <!-- Основные фильтры -->
            <RowDefinition Height="*"/>
            <!-- Таблица результатов -->
            <RowDefinition Height="Auto"/>
            <!-- Панель действий -->
        </Grid.RowDefinitions>

        <!-- 1. ШАПКА -->
        <Grid Grid.Row="0">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="Auto"/>
                <ColumnDefinition Width="*"/>
                <ColumnDefinition Width="Auto"/>
            </Grid.ColumnDefinitions>


            <StackPanel Orientation="Horizontal" Grid.Column="0">
                <Image Source="/Resources/logo.png" Width="40" Height="40" Margin="0,0,10,0"/>
                <Label Content="Справочник ГОСТ" 
                       FontSize="16" FontWeight="Bold" VerticalAlignment="Center"/>
            </StackPanel>

            <Button Grid.Column="1" x:Name="UserInfoBtn" HorizontalAlignment="Center" Background="Transparent" BorderThickness="0" Cursor="Hand" Click="UserInfoBtn_Click" >
                <StackPanel Orientation="Horizontal" Margin="5">
                    <Border Width="45" Height="45" Background="LightGray" BorderBrush="Gray" BorderThickness="1" Margin="0,0,10,0">
                        <Image x:Name="UserImage" Source="/Resources/UserAvatar.png"/>
                    </Border>
                    <StackPanel VerticalAlignment="Center" >
                        <TextBlock x:Name="UserFioTextBlock"/>
                        <TextBlock x:Name="RoleTextBlock"/>
                    </StackPanel>
                </StackPanel>
            </Button>
            <StackPanel Grid.Column="2" Orientation="Horizontal">
                <Button Content="Избранное" Margin="5,0" Width="80" Height="30" Click="OpenFavorites_Click"
 Style="{StaticResource GrayRoundedButton}"/>
            </StackPanel>
        </Grid>  
        <GroupBox Grid.Row="1" Header="Быстрый поиск" Margin="0,10,0,10">
            <Grid>
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="Auto"/>
                    <ColumnDefinition Width="Auto"/>
                    <ColumnDefinition Width="Auto"/>
                    <ColumnDefinition Width="Auto"/>
                </Grid.ColumnDefinitions>

                <StackPanel Grid.Column="0" Orientation="Horizontal">
                    <Label Content="Материал:" VerticalAlignment="Center"/>
                    <ComboBox x:Name="MaterialComboBox" Width="150" Style="{StaticResource RoundedComboBox}" SelectionChanged="MaterialComboBox_SelectionChanged"/>
                </StackPanel>
                <StackPanel Grid.Column="1" Orientation="Horizontal" Margin="20,0,0,0">
                    <Label Content="Тип изделия:"/>
                    <ComboBox x:Name="TypeComboBox" Style="{StaticResource RoundedComboBox}" Width="150" SelectionChanged="TypeComboBox_SelectionChanged"/>
                </StackPanel>
                <StackPanel Grid.Column="2" Orientation="Horizontal" Margin="80,0,0,0">
                    <TextBox x:Name="SearchTextBox" Width="150" KeyDown="SearchTextBox_KeyDown" TextChanged="SearchTextBox_TextChanged" />
                    <Button x:Name="SearchButton" Width="70" Content="Найти" Style="{StaticResource RoundedButton}" Click="SearchButton_Click"/>
                </StackPanel>
                <StackPanel Grid.Column="3" Orientation="Horizontal" Margin="20,0">
                </StackPanel>
            </Grid>
        </GroupBox>
        <DataGrid Grid.Row="2" x:Name="ResultsDataGrid" 
          AutoGenerateColumns="False"
          MouseDoubleClick="Result_DoubleClick"
          CanUserAddRows="False"
          CanUserDeleteRows="False"
          CanUserReorderColumns="True"
          CanUserResizeColumns="True"
          CanUserResizeRows="False"
          CanUserSortColumns="True"
          SelectionMode="Single"
          SelectionUnit="FullRow"
          GridLinesVisibility="Horizontal"
          AlternatingRowBackground="#FFF0F0F0"
          IsReadOnly="True"
          Visibility="Collapsed"
          HorizontalAlignment="Stretch"
          HorizontalContentAlignment="Stretch">
        </DataGrid>

        <!-- 4. ПАНЕЛЬ ДЕЙСТВИЙ -->
        <StackPanel Grid.Row="3" Orientation="Horizontal" Margin="0,10,0,0">
            <Button x:Name="CalculatorWindow" Width="100" Height="20" Content="Калькулятор СИ" Click="CalculatorWindow_Click"
 Style="{StaticResource GrayRoundedButton}"/>
            <Button Content="История просмотра" Margin="10,0,0,0" Click="ViewHistory_Click"
 Style="{StaticResource GrayRoundedButton}"/>
            <TextBlock x:Name="ResultsCountText" Margin="20,0,0,0" 
                       VerticalAlignment="Center"
                       FontWeight="SemiBold" Foreground="Gray"/>
        </StackPanel>
    </Grid>
</Window>