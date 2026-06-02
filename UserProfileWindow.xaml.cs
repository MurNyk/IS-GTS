<Window x:Class="IS_GTS.Windows.UserProfileWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Мой профиль" Height="550" Width="700"
        WindowStartupLocation="CenterOwner"
        ResizeMode="NoResize"
        Background="#FFFFFFF6">

    <Grid Margin="20">
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>

        <!-- Заголовок -->
        <TextBlock Grid.Row="0" Text="Мой профиль" 
                   FontSize="20" FontWeight="Bold" 
                   HorizontalAlignment="Center" Margin="0,0,0,25"/>

        <!-- Две колонки (Личные данные + Контакты + Безопасность) -->
        <Grid Grid.Row="1" Margin="0,0,0,20">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="*"/>
                <ColumnDefinition Width="*"/>
            </Grid.ColumnDefinitions>

            <!-- Левая колонка - Личные данные -->
            <Border Grid.Column="0" Background="#F5F5F5" CornerRadius="8" Padding="15" Margin="0,0,10,0">
                <StackPanel>
                    <TextBlock Text="Личные данные" FontWeight="Bold" FontSize="14" Margin="0,0,0,15"/>

                    <TextBlock Text="Фамилия:" Margin="0,5,0,0"/>
                    <TextBlock x:Name="LastNameText" Margin="0,2,0,10" Foreground="#333333"/>

                    <TextBlock Text="Имя:" Margin="0,5,0,0"/>
                    <TextBlock x:Name="FirstNameText" Margin="0,2,0,10" Foreground="#333333"/>

                    <TextBlock Text="Отчество:" Margin="0,5,0,0"/>
                    <TextBlock x:Name="PatronymicText" Margin="0,2,0,10" Foreground="#333333"/>

                    <TextBlock Text="Дата рождения:" Margin="0,5,0,0"/>
                    <TextBlock x:Name="BirthDateText" Margin="0,2,0,10" Foreground="#333333"/>

                    <TextBlock Text="Роль:" Margin="0,5,0,0"/>
                    <TextBlock x:Name="RoleText" Margin="0,2,0,10" Foreground="#333333"/>
                </StackPanel>
            </Border>

            <!-- Правая колонка - Контакты + Безопасность -->
            <StackPanel Grid.Column="1" Margin="10,0,0,0">
                <Border Background="#F5F5F5" CornerRadius="8" Padding="15" Margin="0,0,0,10">
                    <StackPanel>
                        <TextBlock Text="Контакты" FontWeight="Bold" FontSize="14" Margin="0,0,0,15"/>

                        <TextBlock Text="Логин:" Margin="0,5,0,0"/>
                        <TextBox x:Name="LoginTextBox" Height="30" Margin="0,2,0,10"/>

                        <TextBlock Text="Телефон:" Margin="0,5,0,0"/>
                        <TextBox x:Name="PhoneTextBox" Height="30" Margin="0,2,0,10"/>

                        <TextBlock Text="Email:" Margin="0,5,0,0"/>
                        <TextBox x:Name="EmailTextBox" Height="30" Margin="0,2,0,10"/>
                    </StackPanel>
                </Border>

                <Border Background="#F5F5F5" CornerRadius="8" Padding="15">
                    <StackPanel>
                        <TextBlock Text="Безопасность" FontWeight="Bold" FontSize="14" Margin="0,0,0,10"/>
                        <Button x:Name="ChangePasswordButton" Content="Сменить пароль" Height="27"
        Click="ChangePasswordButton_Click"  Style="{StaticResource GrayRoundedButton}"/>

                    </StackPanel>
                </Border>
            </StackPanel>
        </Grid>

        <!-- Кнопки -->
        <StackPanel Grid.Row="2" Orientation="Horizontal" HorizontalAlignment="Center">
            <Button x:Name="CloseButton" Content="Закрыть" 
        Click="CloseButton_Click" 
        Width="100" Height="35" Margin="10"  Style="{StaticResource GrayRoundedButton}"/>

            <Button x:Name="SaveButton" Content="Сохранить изменения" 
                    Click="SaveButton_Click" 
                    Width="140" Height="35" Style="{StaticResource RoundedButton}"/>
        </StackPanel>

        <!-- Сообщение -->
        <TextBlock x:Name="MessageText" Grid.Row="3" 
                   Foreground="Green" HorizontalAlignment="Center" 
                   Margin="0,15,0,0" Visibility="Collapsed"/>
    </Grid>
</Window>