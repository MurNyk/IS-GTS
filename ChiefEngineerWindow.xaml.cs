<Window x:Class="IS_GTS.Windows.ChiefEngineerWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:IS_GTS.Windows"
        mc:Ignorable="d"
        Title="Панель главного инженера" Height="700" Width="1000" 
        WindowStartupLocation="CenterScreen">

    <Grid Margin="10">
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="300"/>
            <RowDefinition Height="300"/>
            <RowDefinition Height="*"/>
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
                <Label Content="Панель главного инженера" 
                       FontSize="16" FontWeight="Bold" VerticalAlignment="Center"/>
            </StackPanel>

            <Button Grid.Column="1" x:Name="UserInfoBtn" 
                    HorizontalAlignment="Center" 
                    Background="Transparent" 
                    BorderThickness="0" 
                    Cursor="Hand" 
                    Click="UserInfoBtn_Click">
                <StackPanel Orientation="Horizontal" Margin="5">
                    <Border Width="45" Height="45" Background="LightGray" 
                            BorderBrush="Gray" BorderThickness="1" Margin="0,0,10,0">
                        <Image x:Name="UserImage" Source="/Resources/UserAvatar.png"/>
                    </Border>
                    <StackPanel VerticalAlignment="Center">
                        <TextBlock x:Name="UserFioTextBlock"/>
                        <TextBlock x:Name="RoleTextBlock" Text="Главный инженер"/>
                    </StackPanel>
                </StackPanel>
            </Button>

            <StackPanel Grid.Column="2" Orientation="Horizontal">
                <Button Content="Выйти" Margin="5,0" Width="80" Height="30" 
                        Click="LogoutButton_Click" Style="{StaticResource GrayRoundedButton}"/>
            </StackPanel>
        </Grid>

        <!-- 2. ВЕРХНИЕ БЛОКИ (2 шт) -->
        <Grid Grid.Row="1" Margin="0,20,0,10">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="*"/>
                <ColumnDefinition Width="*"/>
            </Grid.ColumnDefinitions>

            <!-- Блок 1: Статистика -->
            <Border Grid.Column="0" Margin="5,0,10,0" Padding="15" 
        Background="#F5F5F5" CornerRadius="8" 
        BorderBrush="LightGray" BorderThickness="1">
                <Border.Effect>
                    <DropShadowEffect ShadowDepth="5" BlurRadius="10" Opacity="0.3" Color="Black"/>
                </Border.Effect>

                <!-- ⭐ Исправлено: Grid вместо StackPanel, чтобы кнопка была внизу -->
                <Grid>
                    <Grid.RowDefinitions>
                        <RowDefinition Height="*"/>
                        <RowDefinition Height="Auto"/>
                    </Grid.RowDefinitions>

                    <StackPanel Grid.Row="0">
                        <StackPanel Orientation="Horizontal">
                            <TextBlock Text="Статистика по категориям" FontSize="16" FontWeight="Bold" Margin="0,0,0,10"/>
                            <Button x:Name="BackButton" Content="◀ Назад к категориям" 
                        Click="BackButton_Click" Width="140" Height="25" Margin="78,0,0,0" HorizontalAlignment="Right"
                        Visibility="Collapsed"/>
                        </StackPanel>

                        <Grid>
                            <Grid.ColumnDefinitions>
                                <ColumnDefinition Width="*"/>
                                <ColumnDefinition Width="Auto"/>
                            </Grid.ColumnDefinitions>
                            <Grid x:Name="ChartContainer" Grid.Column="0" Height="140" Width="140" 
                      HorizontalAlignment="Center" VerticalAlignment="Center">
                                <TextBlock x:Name="ChartPlaceholder" Text="Загрузка..." 
                               HorizontalAlignment="Center" VerticalAlignment="Center"/>
                            </Grid>
                            <StackPanel x:Name="LegendPanel" Grid.Column="1" Margin="15,0,0,0" Width="160"/>
                        </Grid>
                    </StackPanel>

                    <Button Grid.Row="1" Content="Экспорт статистики в Excel" 
                Click="ExportStatsToExcel_Click" 
                Margin="0,10,0,0"
                Style="{StaticResource RoundedButton}" HorizontalAlignment="Left" Width="180" Height="30" FontWeight="DemiBold"/>
                </Grid>
            </Border>

            <!-- Блок 2: Сравнение профилей -->
            <Border Grid.Column="1" Margin="10,0,5,0" Padding="15" 
                    Background="#F5F5F5" CornerRadius="8" 
                    BorderBrush="LightGray" BorderThickness="1">
                <Border.Effect>
                    <DropShadowEffect ShadowDepth="5" BlurRadius="10" Opacity="0.3" Color="Black"/>
                </Border.Effect>
                <Grid>
                    <Grid.RowDefinitions>
                        <RowDefinition Height="*"/>
                        <RowDefinition Height="Auto"/>
                    </Grid.RowDefinitions>

                    <StackPanel Grid.Row="0">
                        <TextBlock Text="Сравнение профилей" FontSize="16" Margin="0,0,0,10" FontFamily="Sitka Text Semibold"/>
                        <TextBlock Text="Сравнение технических характеристик — выберите до 3 профилей в рамках одного ГОСТа."  
                                   TextWrapping="Wrap" FontSize="14" Margin="0,2,0,0" FontFamily="Sitka Text"/>
                    </StackPanel>

                    <Button Grid.Row="1" Content="Открыть окно сравнения" 
                            Click="OpenComparisonWindow_Click" 
                            Style="{StaticResource RoundedButton}" 
                            FontWeight="DemiBold" HorizontalAlignment="Left" 
                            Width="180" Height="30" Margin="0,10,0,0"/>
                </Grid>
            </Border>
        </Grid>

        <!-- 3. НИЖНИЕ БЛОКИ (2 шт) -->
        <Grid Grid.Row="2" Margin="0,10,0,20">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="*"/>
                <ColumnDefinition Width="*"/>
            </Grid.ColumnDefinitions>

            <!-- Блок 3: Документы ГОСТ -->
            <Border Grid.Column="0" Margin="5,0,10,0" Padding="15" 
                    Background="#F5F5F5" CornerRadius="8" 
                    BorderBrush="LightGray" BorderThickness="1">
                <Border.Effect>
                    <DropShadowEffect ShadowDepth="5" BlurRadius="10" Opacity="0.3" Color="Black"/>
                </Border.Effect>
                <Grid>
                    <Grid.RowDefinitions>
                        <RowDefinition Height="*"/>
                        <RowDefinition Height="Auto"/>
                    </Grid.RowDefinitions>

                    <StackPanel Grid.Row="0">
                        <TextBlock Text="Документы ГОСТ" FontSize="16" Margin="0,0,0,10" FontFamily="Sitka Text Semibold"/>
                        <TextBlock Text="Нормативная документация в формате — просмотр и скачивание файлов."  
                                   TextWrapping="Wrap" FontSize="14" Margin="0,2,0,0" FontFamily="Sitka Text"/>
                    </StackPanel>

                    <Button Grid.Row="1" Content="Открыть документы" 
                            Click="OpenGostDocuments_Click" 
                            Style="{StaticResource RoundedButton}" 
                            HorizontalAlignment="Left" Width="180" Height="30" FontWeight="DemiBold"
                            Margin="0,10,0,0"/>
                </Grid>
            </Border>

            <!-- Блок 4: Сортамент -->
            <Border Grid.Column="1" Margin="10,0,5,0" Padding="15" 
                    Background="#F5F5F5" CornerRadius="8" 
                    BorderBrush="LightGray" BorderThickness="1">
                <Border.Effect>
                    <DropShadowEffect ShadowDepth="5" BlurRadius="10" Opacity="0.3" Color="Black"/>
                </Border.Effect>
                <Grid>
                    <Grid.RowDefinitions>
                        <RowDefinition Height="*"/>
                        <RowDefinition Height="Auto"/>
                    </Grid.RowDefinitions>

                    <StackPanel Grid.Row="0">
                        <TextBlock Text="Сортамент" FontSize="16" Margin="0,0,0,10" FontFamily="Sitka Text Semibold"/>
                        <TextBlock Text="Полноценный поиск профилей и ГОСТов с фильтрацией и экспортом" 
                                   TextWrapping="Wrap" FontSize="14" Margin="0,2,0,0" FontFamily="Sitka Text"/>
                    </StackPanel>

                    <Button Grid.Row="1" Content="Открыть справочник ГОСТ" 
                            Click="OpenSearchWindow_Click" 
                            Style="{StaticResource RoundedButton}" 
                            FontWeight="DemiBold" HorizontalAlignment="Left" 
                            Width="180" Height="30" Margin="0,10,0,0"/>
                </Grid>
            </Border>
        </Grid>

        <!-- 4. ПУСТОЕ ПРОСТРАНСТВО -->
        <Grid Grid.Row="3"/>
    </Grid>
</Window>