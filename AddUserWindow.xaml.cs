<Window x:Class="IS_GTS.Windows.AddUserWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Добавление пользователя" Height="650" Width="700"
        WindowStartupLocation="CenterOwner"
        ResizeMode="NoResize" Background="#FFFFFFF6">

    <Window.Resources>
        <Style x:Key="RequiredMark" TargetType="TextBlock">
            <Setter Property="Foreground" Value="Red"/>
            <Setter Property="FontSize" Value="14"/>
            <Setter Property="FontWeight" Value="Bold"/>
            <Setter Property="Margin" Value="2,0,0,0"/>
        </Style>
    </Window.Resources>

    <Grid Margin="10">
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>

        <Grid Grid.Row="0" Margin="0,10">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="Auto"/>
                <ColumnDefinition Width="*"/>
            </Grid.ColumnDefinitions>
            <Button x:Name="BackButton" Content="Назад" Style="{StaticResource GrayRoundedButton}" Width="70" Height="30" Click="BackButton_Click"/>
            <TextBlock Grid.Column="1" Text="Добавление пользователя" FontSize="16" FontWeight="Bold" 
                       HorizontalAlignment="Center" VerticalAlignment="Center"/>
        </Grid>

        <Grid Grid.Row="1" Margin="0,20">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="*"/>
                <ColumnDefinition Width="*"/>
            </Grid.ColumnDefinitions>

            <Border Grid.Column="0" Background="#F5F5F5" CornerRadius="8" Padding="15" Margin="10,0,10,0"
                    BorderBrush="LightGray" BorderThickness="1">
                <StackPanel>
                    <StackPanel Orientation="Horizontal" Margin="0,5">
                        <TextBlock Text="Фамилия:" VerticalAlignment="Center"/>
                        <TextBlock Style="{StaticResource RequiredMark}" Text="*" VerticalAlignment="Center"/>
                    </StackPanel>
                    <TextBox x:Name="LastNameTextBox" Height="30" Margin="0,0,0,10"
                             BorderBrush="Gray" BorderThickness="1"/>

                    <StackPanel Orientation="Horizontal" Margin="0,5">
                        <TextBlock Text="Имя:" VerticalAlignment="Center"/>
                        <TextBlock Style="{StaticResource RequiredMark}" Text="*" VerticalAlignment="Center"/>
                    </StackPanel>
                    <TextBox x:Name="FirstNameTextBox" Height="30" Margin="0,0,0,10"
                             BorderBrush="Gray" BorderThickness="1"/>

                    <TextBlock Text="Отчество:" Margin="0,5"/>
                    <TextBox x:Name="PatronymicTextBox" Height="30" Margin="0,0,0,10"
                             BorderBrush="Gray" BorderThickness="1"/>

                    <TextBlock Text="Дата рождения:" Margin="0,5"/>
                    <DatePicker x:Name="BirthDatePicker" Height="30" Margin="0,0,0,10"
                                BorderBrush="Gray" BorderThickness="1"/>

                    <TextBlock Text="Телефон:" Margin="0,5"/>
                    <TextBox x:Name="PhoneTextBox" Height="30" Margin="0,0,0,10"
                             BorderBrush="Gray" BorderThickness="1"/>
                </StackPanel>
            </Border>

            <Border Grid.Column="1" Background="#F5F5F5" CornerRadius="8" Padding="15" Margin="10,0,10,0"
                    BorderBrush="LightGray" BorderThickness="1">
                <StackPanel>
                    <StackPanel Orientation="Horizontal" Margin="0,5">
                        <TextBlock Text="Email:" VerticalAlignment="Center"/>
                        <TextBlock Style="{StaticResource RequiredMark}" Text="*" VerticalAlignment="Center"/>
                    </StackPanel>
                    <TextBox x:Name="EmailTextBox" Height="30" Margin="0,0,0,10" 
                             TextChanged="EmailTextBox_TextChanged"
                             PreviewKeyDown="EmailTextBox_PreviewKeyDown"
                             BorderBrush="Gray" BorderThickness="1"/>

                    <StackPanel Orientation="Horizontal" Margin="0,5">
                        <TextBlock Text="Логин:" VerticalAlignment="Center"/>
                        <TextBlock Style="{StaticResource RequiredMark}" Text="*" VerticalAlignment="Center"/>
                    </StackPanel>
                    <TextBox x:Name="LoginTextBox" Height="30" Margin="0,0,0,10"
                             BorderBrush="Gray" BorderThickness="1"/>

                    <StackPanel Orientation="Horizontal" Margin="0,5">
                        <TextBlock Text="Пароль:" VerticalAlignment="Center"/>
                        <TextBlock Style="{StaticResource RequiredMark}" Text="*" VerticalAlignment="Center"/>
                    </StackPanel>
                    <PasswordBox x:Name="PasswordBox" Height="30" Margin="0,0,0,10"
                                 BorderBrush="Gray" BorderThickness="1"/>

                    <StackPanel Orientation="Horizontal" Margin="0,5">
                        <TextBlock Text="Подтверждение пароля:" VerticalAlignment="Center"/>
                        <TextBlock Style="{StaticResource RequiredMark}" Text="*" VerticalAlignment="Center"/>
                    </StackPanel>
                    <PasswordBox x:Name="ConfirmPasswordBox" Height="30" Margin="0,0,0,10"
                                 BorderBrush="Gray" BorderThickness="1"/>

                    <StackPanel Orientation="Horizontal" Margin="0,5">
                        <TextBlock Text="Роль:" Margin="0,5"/>
                        <TextBlock Style="{StaticResource RequiredMark}" Text="*" VerticalAlignment="Center"/>
                    </StackPanel>
                    <StackPanel Margin="0,5">
                        <RadioButton x:Name="EngineerRadioButton" Content="Инженер" GroupName="RoleGroup" 
                                     IsChecked="True" Margin="0,5"/>
                        <RadioButton x:Name="MainEngineerRadioButton" Content="Главный инженер" GroupName="RoleGroup" Margin="0,5"/>
                        <RadioButton x:Name="AdminRadioButton" Content="Администратор" GroupName="RoleGroup" Margin="0,5"/>
                    </StackPanel>
                </StackPanel>
            </Border>
        </Grid>

        <StackPanel Grid.Row="2" Orientation="Horizontal" HorizontalAlignment="Center" Margin="0,7">
            <Button Content="Отмена" Click="CancelButton_Click" Width="100" Style="{StaticResource GrayRoundedButton}" Height="35" Margin="5"/>

            <Button x:Name="AddUserButton" Style="{StaticResource RoundedButton}" Content="Добавить пользователя" 
                    Click="AddUserButton_Click" Width="160" Height="35" Margin="5"/>
            
        </StackPanel>

        <TextBlock Grid.Row="3" Text="* - обязательные к заполнению поля" 
                   Foreground="Red" FontSize="11" 
                   HorizontalAlignment="Left" Margin="10,0"/>

        <TextBlock x:Name="ErrorText" Grid.Row="4" Foreground="Red" 
                   HorizontalAlignment="Center" TextWrapping="Wrap"
                   Visibility="Collapsed" Margin="0,10"/>
    </Grid>
</Window>