<Window x:Class="IS_GTS.Windows.AuthWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:IS_GTS.Windows"
        mc:Ignorable="d"
        Title="Авторизация" Height="550" Width="900" WindowStartupLocation="CenterScreen">
    <Grid Background="White">
        <Grid.RowDefinitions>
            <RowDefinition Height="*"/>
            <RowDefinition Height="5*"/>
        </Grid.RowDefinitions>

        <Image Grid.Row="0" Source="/Resources/gts.png" Margin="0,14,0,0"/>


        <Border Grid.Row="1" CornerRadius="30" BorderThickness="1" Padding="20" VerticalAlignment="Center" HorizontalAlignment="Center" Background="#FFFFFFF6">

            <Border.Effect>
                <DropShadowEffect ShadowDepth="5" 
                          BlurRadius="10" 
                          Opacity="0.3" 
                          Color="Black"/>
            </Border.Effect>
            <StackPanel VerticalAlignment="Center" HorizontalAlignment="Center">
                <TextBlock Text="Авторизация" HorizontalAlignment="Center" Margin="15" FontSize="18" FontWeight="SemiBold" FontFamily="Sitka Small Semibold"></TextBlock>

                <StackPanel Orientation="Horizontal" Margin="10">
                    <TextBlock Text="Логин: " FontFamily="Sitka Small"></TextBlock>
                    <TextBox Width="100" Margin="8,0,0,0" x:Name="LoginTextBox" Text="vysokLP"></TextBox>
                </StackPanel>

                <StackPanel Orientation="Horizontal" Margin="10">
                    <TextBlock Text="Пароль: " FontFamily="Sitka Small"></TextBlock>
                    <TextBox Width="100" x:Name="ParolTextBox" Visibility="Collapsed"></TextBox>
                    <PasswordBox Width="100" x:Name="ParolBox" Password="vysokovlp123"></PasswordBox>
                </StackPanel>
                <CheckBox x:Name="VisiblyPassword" 
          Content="Показать пароль" 
          Margin="55,0,10,10" 
          FontSize="10" 
          VerticalAlignment="Center" 
          VerticalContentAlignment="Center"
          Checked="VisiblyPassword_Checked" 
          Unchecked="VisiblyPassword_Unchecked" 
          FontFamily="Sitka Small"/>
                <Button x:Name="AuthButton" Content="Войти" VerticalAlignment="Center" Width="65" Height="25" FontWeight="DemiBold"
                         Style="{StaticResource RoundedButton}" HorizontalAlignment="Center" Click="AuthButton_Click"/>
            </StackPanel>
        </Border>
    </Grid>
</Window>
