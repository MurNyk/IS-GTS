<Window x:Class="IS_GTS.Windows.CalculatorWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:IS_GTS.Windows"
        mc:Ignorable="d"
        Title="Калькулятор СИ" Height="630" Width="700" Background="#FFFFFFF6">

    <Window.Resources>
        <!-- Стиль для TextBox с подсказкой и непрозрачным фоном -->
        <Style x:Key="HintedTextBox" TargetType="TextBox">
            <Setter Property="Background" Value="White"/>
            <Setter Property="BorderBrush" Value="#CCCCCC"/>
            <Setter Property="BorderThickness" Value="1"/>
            <Setter Property="Padding" Value="5,3"/>
            <Setter Property="VerticalContentAlignment" Value="Center"/>
            <Setter Property="Opacity" Value="1"/>
            <Style.Triggers>
                <Trigger Property="Text" Value="">
                    <Setter Property="Background" Value="White"/>
                    <Setter Property="Foreground" Value="Gray"/>
                    <Setter Property="FontStyle" Value="Italic"/>
                </Trigger>
                <Trigger Property="IsFocused" Value="True">
                    <Setter Property="Background" Value="White"/>
                    <Setter Property="Foreground" Value="Black"/>
                    <Setter Property="FontStyle" Value="Normal"/>
                </Trigger>
            </Style.Triggers>
        </Style>
    </Window.Resources>

    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>

        <Grid Grid.Row="0">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="Auto"/>
            </Grid.ColumnDefinitions>

            <StackPanel Grid.Column="0" Orientation="Horizontal" Margin="20,10,0,0">
                <Button x:Name="BackButton" Content="Назад" Width="70" Height="25" Style="{StaticResource GrayRoundedButton}" Click="BackButton_Click"/>
                <Label Content="Перевод единиц измерения в СИ" Margin="150,0,0,0"  FontSize="16" FontWeight="Bold" VerticalAlignment="Center"/>
            </StackPanel>
        </Grid>

        <Grid Grid.Row="1">
            <StackPanel Orientation="Horizontal" Margin="20,20,0,0">
                <Label Content="Категория: "/>
                <ComboBox x:Name="CategoryComboBox" Width="180"/>
            </StackPanel>
        </Grid>

        <Grid Grid.Row="2">
            <StackPanel Orientation="Horizontal" Margin="23,10,0,0">
                <Label Content="Величина: "/>
                <TextBox x:Name="ValueTextBox" 
                         Width="180" 
                         Style="{StaticResource HintedTextBox}"
                         TextChanged="ValueTextBox_TextChanged"/>
            </StackPanel>
        </Grid>

        <Grid Grid.Row="3">
            <StackPanel Orientation="Horizontal" Margin="20,40,0,0">
                <Label Content="Из: "/>
                <ComboBox x:Name="IzValueComboBox" Width="140" 
                  SelectionChanged="IzValueComboBox_SelectionChanged"/>
            </StackPanel>
        </Grid>

        <Grid Grid.Row="4">
            <StackPanel Orientation="Horizontal" Margin="27,10,0,0">
                <Label Content="В: "/>
                <ComboBox x:Name="VValueComboBox" Width="140" 
                  SelectionChanged="VValueComboBox_SelectionChanged"/>
            </StackPanel>
        </Grid>

        <Grid Grid.Row="6" Margin="20,20,20,0">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="*"/>
                <ColumnDefinition Width="*"/>
            </Grid.ColumnDefinitions>

            <!-- Результат -->
            <Border Grid.Column="0" Height="270" Width="310" Background="#F5F5F5" CornerRadius="8" Padding="15" Margin="0,0,10,0">
                <StackPanel>
                    <TextBlock Text="Результат" FontWeight="Bold" FontSize="14" Margin="0,0,0,10"/>
                    <TextBlock x:Name="ResultTextBlock" 
                               FontSize="18" 
                               FontWeight="Bold" 
                               Foreground="#4CAF50"
                               TextWrapping="Wrap"/>
                </StackPanel>
            </Border>

            <!-- Пояснение -->
            <Border Grid.Column="1" Height="270" Width="310" Background="#F5F5F5" CornerRadius="8" Padding="15" Margin="10,0,0,0">
                <StackPanel>
                    <TextBlock Text="О единице измерения" FontWeight="Bold" FontSize="14" Margin="0,0,0,10"/>
                    <ScrollViewer MaxHeight="120" VerticalScrollBarVisibility="Auto">
                        <TextBlock x:Name="DescriptionTextBlock" 
                                   Text="Выберите категорию"
                                   FontSize="12" 
                                   Foreground="#555555"
                                   TextWrapping="Wrap"/>
                    </ScrollViewer>
                </StackPanel>
            </Border>
        </Grid>
    </Grid>
</Window>