<Window x:Class="IS_GTS.Windows.UserDetailsWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Информация о пользователе" Height="750" Width="800"
        WindowStartupLocation="CenterOwner"
        ResizeMode="NoResize"
        Background="#FFFFFFF6">

    <Grid Margin="20">
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>

        <!-- Заголовок -->
        <TextBlock Grid.Row="0" Text="Информация о пользователе" 
                   FontSize="18" FontWeight="Bold" HorizontalAlignment="Center" Margin="0,0,0,20"/>

        <!-- Две колонки -->
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
                    <TextBox x:Name="LastNameTextBox" Height="30" Margin="0,2,0,10"/>

                    <TextBlock Text="Имя:" Margin="0,5,0,0"/>
                    <TextBox x:Name="FirstNameTextBox" Height="30" Margin="0,2,0,10"/>

                    <TextBlock Text="Отчество:" Margin="0,5,0,0"/>
                    <TextBox x:Name="PatronymicTextBox" Height="30" Margin="0,2,0,10"/>

                    <TextBlock Text="Дата рождения:" Margin="0,5,0,0"/>
                    <DatePicker x:Name="BirthDatePicker" Height="30" Margin="0,2,0,10"/>

                    <TextBlock Text="Телефон:" Margin="0,5,0,0"/>
                    <TextBox x:Name="PhoneTextBox" Height="30" Margin="0,2,0,10"/>

                    <TextBlock Text="Email:" Margin="0,5,0,0"/>
                    <TextBox x:Name="EmailTextBox" Height="30" Margin="0,2,0,10"/>
                </StackPanel>
            </Border>

            <!-- Правая колонка - Учетные данные -->
            <Border Grid.Column="1" Background="#F5F5F5" CornerRadius="8" Padding="15" Margin="10,0,0,0">
                <StackPanel>
                    <TextBlock Text="Учетные данные" FontWeight="Bold" FontSize="14" Margin="0,0,0,15"/>

                    <TextBlock Text="Логин:" Margin="0,5,0,0"/>
                    <TextBox x:Name="LoginTextBox" Height="30" Margin="0,2,0,10"/>

                    <TextBlock Text="Роль:" Margin="0,5,0,0"/>
                    <ComboBox x:Name="RoleComboBox" Height="30" Margin="0,2,0,10"
                              DisplayMemberPath="RoleName" SelectedValuePath="RoleID"/>

                    <TextBlock Text="Статус:" Margin="0,5,0,0"/>
                    <StackPanel Orientation="Horizontal" Margin="0,2,0,10">
                        <RadioButton x:Name="ActiveRadioButton" Content="Активен" GroupName="StatusGroup" Margin="0,0,20,0"/>
                        <RadioButton x:Name="BlockedRadioButton" Content="Заблокирован" GroupName="StatusGroup"/>
                    </StackPanel>

                    <TextBlock Text="Дата регистрации:" Margin="0,5,0,0"/>
                    <TextBlock x:Name="RegistrationDateText" Margin="0,2,0,10" Foreground="Gray"/>

                    <TextBlock Text="Последний вход:" Margin="0,5,0,0"/>
                    <TextBlock x:Name="LastVisitText" Margin="0,2,0,10" Foreground="Gray"/>
                </StackPanel>
            </Border>
        </Grid>

        <!-- Статистика -->
        <Border Grid.Row="2" Background="#F5F5F5" CornerRadius="8" Padding="15" Margin="0,0,0,20">
            <StackPanel>
                <TextBlock Text="Статистика" FontWeight="Bold" FontSize="14" Margin="0,0,0,10"/>
                <StackPanel Orientation="Horizontal">
                    <TextBlock Text="В избранном:" Margin="0,0,10,0"/>
                    <TextBlock x:Name="FavoritesCountText" Text="0" FontWeight="Bold" Margin="0,0,30,0"/>
                    <TextBlock Text="Просмотров:" Margin="0,0,10,0"/>
                    <TextBlock x:Name="VisitsCountText" Text="0" FontWeight="Bold"/>
                </StackPanel>
            </StackPanel>
        </Border>

        <!-- Кнопки действий -->
        <StackPanel Grid.Row="3" Orientation="Horizontal" HorizontalAlignment="Center" Margin="0,0,0,20">
            <Button x:Name="ResetPasswordButton" Content="Сбросить пароль" Click="ResetPasswordButton_Click" 
        Width="120" Height="35" Margin="5"
         Style="{StaticResource GrayRoundedButton}"/>

            <Button x:Name="SaveButton" Content="Сохранить изменения" Click="SaveButton_Click" 
        Width="140" Height="35" Margin="5" Style="{StaticResource RoundedButton}"/>

            <!-- Замените текущую кнопку BlockButton на эту -->
            <Button x:Name="BlockButton" 
        Content="Заблокировать" 
        Click="BlockButton_Click" 
        Width="120" Height="35" Margin="5"
        Background="#FFBAAF" 
        Foreground="Black" 
        BorderBrush="Transparent" 
        BorderThickness="0">
                <Button.Template>
                    <ControlTemplate TargetType="Button">
                        <Border x:Name="Border"
                    Background="{TemplateBinding Background}"
                    BorderBrush="{TemplateBinding BorderBrush}"
                    BorderThickness="{TemplateBinding BorderThickness}"
                    CornerRadius="4">
                            <ContentPresenter HorizontalAlignment="Center" VerticalAlignment="Center"/>
                        </Border>
                        <ControlTemplate.Triggers>
                            <Trigger Property="IsMouseOver" Value="True">
                                <Setter TargetName="Border" Property="Background" Value="#FFA090"/>
                            </Trigger>
                            <Trigger Property="IsPressed" Value="True">
                                <Setter TargetName="Border" Property="Background" Value="#E09080"/>
                            </Trigger>
                        </ControlTemplate.Triggers>
                    </ControlTemplate>
                </Button.Template>
            </Button>

            <Button Content="Закрыть" Click="CloseButton_Click" 
        Width="100" Height="35" Margin="5" Style="{StaticResource GrayRoundedButton}"/>
        </StackPanel>

        <!-- Сообщение -->
        <TextBlock x:Name="MessageText" Grid.Row="4" 
                   Foreground="Green" HorizontalAlignment="Center" 
                   Margin="0,10,0,0" Visibility="Collapsed"/>
    </Grid>
</Window>