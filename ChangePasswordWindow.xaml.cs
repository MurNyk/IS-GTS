<Window x:Class="IS_GTS.Windows.ChangePasswordWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Смена пароля" Height="400" Width="400"
        WindowStartupLocation="CenterOwner"
        ResizeMode="NoResize" Background="#FFFFFFF6">

    <Grid Margin="20">
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>

        <TextBlock Grid.Row="0" Text="Смена пароля" FontSize="16" 
                   FontWeight="Bold" HorizontalAlignment="Center" Margin="0,0,0,20"/>

        <Border Grid.Row="1" Background="#F5F5F5" CornerRadius="8" Padding="15" Margin="5,0,5,0"
                BorderBrush="LightGray" BorderThickness="1">
            <StackPanel>
                <TextBlock Text="Старый пароль:" Margin="0,0,0,5"/>
                <PasswordBox x:Name="OldPasswordBox" Height="30" Margin="0,0,0,15"
                             BorderBrush="Gray" BorderThickness="1"/>

                <TextBlock Text="Новый пароль:" Margin="0,0,0,5"/>
                <PasswordBox x:Name="NewPasswordBox" Height="30" Margin="0,0,0,15"
                             BorderBrush="Gray" BorderThickness="1"/>

                <TextBlock Text="Подтверждение:" Margin="0,0,0,5"/>
                <PasswordBox x:Name="ConfirmPasswordBox" Height="30"
                             BorderBrush="Gray" BorderThickness="1"/>
            </StackPanel>
        </Border>

        <StackPanel Grid.Row="2" Orientation="Horizontal" 
                    HorizontalAlignment="Center" Margin="0,20,0,0">
            <Button Content="Отмена" Click="Cancel_Click" Width="100" Margin="5" Height="30"
        Style="{StaticResource GrayRoundedButton}"/>
            <Button Content="Изменить" Click="ChangePassword_Click" 
                    Width="80" Margin="5" Style="{StaticResource RoundedButton}" Height="30"/>
        </StackPanel>

        <TextBlock x:Name="ErrorText" Grid.Row="3" 
                   Foreground="Red" HorizontalAlignment="Center" 
                   Margin="5" Visibility="Collapsed"/>
    </Grid>
</Window>