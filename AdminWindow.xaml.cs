<Window x:Class="IS_GTS.Windows.AdminWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:IS_GTS.Windows"
        mc:Ignorable="d"
        Title="Админ панель" Height="500" Width="900" Background="#FFFFFFF6">

    <Window.Resources>
        <Style x:Key="CurrentUserRowStyle" TargetType="DataGridRow">
            <Style.Triggers>
                <DataTrigger Binding="{Binding IsCurrentUser}" Value="True">
                    <Setter Property="Background" Value="#E3F2FD"/>
                    <Setter Property="FontWeight" Value="SemiBold"/>
                </DataTrigger>
            </Style.Triggers>
        </Style>
    </Window.Resources>

    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="250*"/>
            <RowDefinition Height="Auto"/>
        </Grid.RowDefinitions>

        <Grid Grid.Row="0">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="120"/>
                <ColumnDefinition Width="*"/>
            </Grid.ColumnDefinitions>
            <StackPanel Orientation="Horizontal" Grid.Column="0" Margin="0, 10,0,0">
                <Button x:Name="BackButton" Content="Назад" Style="{StaticResource GrayRoundedButton}" VerticalAlignment="Center" Height="30" Width="70" Margin="20,0,0,0" Click="BackButton_Click"/>
            </StackPanel>
            <TextBlock Text="Административная панель" Grid.Column="1" HorizontalAlignment="Center" VerticalAlignment="Center" FontSize="16" FontWeight="Bold"/>
        </Grid>

        <StackPanel Orientation="Horizontal" Grid.Row="1" Margin="0,15,0,0">
            <Label Content="Поиск пользователя:"/>
            <TextBox x:Name="SearchTextBox" Width="120" TextChanged="SearchTextBox_TextChanged"/>
            <Button x:Name="SearchButton" Content="Найти" Width="70" Style="{StaticResource GrayRoundedButton}" Click="SearchButton_Click"/>
            <Button x:Name="AddButton" Content="+ Добавить пользователя" Style="{StaticResource RoundedButton}" Margin="250,0,0,0" Click="AddButton_Click" Width="160"/>
        </StackPanel>

        <DataGrid Grid.Row="2" x:Name="UsersDataGrid" Margin="10" 
                  AutoGenerateColumns="False"
                  CanUserAddRows="False"
                  IsReadOnly="True"
                  RowStyle="{StaticResource CurrentUserRowStyle}"
                  MouseDoubleClick="UsersDataGrid_MouseDoubleClick">
            <DataGrid.Columns>
                <DataGridTextColumn Header="ID" Binding="{Binding UserID}" Width="50"/>
                <DataGridTextColumn Header="ФИО" Binding="{Binding FullNameWithMark}" Width="220"/>
                <DataGridTextColumn Header="Логин" Binding="{Binding UserLogin}" Width="100"/>
                <DataGridTextColumn Header="Роль" Binding="{Binding RoleName}" Width="120"/>
                <DataGridTextColumn Header="Последний вход" Binding="{Binding LastVisit}" Width="180"/>
                <DataGridTextColumn Header="Статус" Binding="{Binding UserStatus}" Width="*"/>
            </DataGrid.Columns>
        </DataGrid>

        <TextBlock Grid.Row="3" VerticalAlignment="Center" Margin="8">
            <Run Text="Всего пользователей:"/>
            <Run x:Name="UsersCountText" Text="0"/>
            <Run Text="Активных:"/>
            <Run x:Name="ActiveCountText" Text="0"/>  
            <Run Text="Заблокированных:"/>
            <Run x:Name="BlockCountText" Text="0"/>
        </TextBlock>
    </Grid>
</Window>