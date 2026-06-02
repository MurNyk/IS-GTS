<Window x:Class="IS_GTS.Windows.ComparisonResultWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Результат сравнения профилей" Height="500" Width="700"
        WindowStartupLocation="CenterOwner"
        Background="#FFFFFFF6"
        SizeToContent="WidthAndHeight"
        MinWidth="500"
        MaxWidth="1200">

    <Grid Margin="10">
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
            <RowDefinition Height="Auto"/>
        </Grid.RowDefinitions>

        <!-- Заголовок -->
        <Border Grid.Row="0" Background="#F5F5F5" CornerRadius="8" Padding="15" Margin="0,0,0,10">
            <StackPanel>
                <TextBlock Text="Результат сравнения профилей" FontSize="16" FontWeight="Bold" 
                           HorizontalAlignment="Center" Margin="0,0,0,5"/>
                <TextBlock x:Name="InfoText" Text="Сравниваемые профили:" FontSize="12" 
                           Foreground="Gray" HorizontalAlignment="Center"/>
            </StackPanel>
        </Border>

        <!-- Таблица сравнения -->
        <ScrollViewer Grid.Row="1" VerticalScrollBarVisibility="Auto" HorizontalScrollBarVisibility="Auto">
            <DataGrid x:Name="ComparisonDataGrid" 
                      AutoGenerateColumns="False"
                      CanUserAddRows="False"
                      CanUserDeleteRows="False"
                      CanUserResizeColumns="True"
                      CanUserSortColumns="False"
                      GridLinesVisibility="All"
                      IsReadOnly="True"
                      MinHeight="300"
                      HorizontalAlignment="Left">
                <DataGrid.Resources>
                    <!-- Стиль для ячейки с использованием DataTemplate -->
                    <Style TargetType="DataGridCell">
                        <Setter Property="Background" Value="White"/>
                        <Setter Property="FontWeight" Value="Normal"/>
                        <Style.Triggers>
                            <DataTrigger Binding="{Binding RelativeSource={RelativeSource Self}, Path=Content.IsCellDifferent}" Value="True">
                                <Setter Property="Background" Value="#FFFFE0"/>
                                <Setter Property="FontWeight" Value="Bold"/>
                            </DataTrigger>
                        </Style.Triggers>
                    </Style>
                </DataGrid.Resources>
            </DataGrid>
        </ScrollViewer>

        <!-- Кнопки -->
        <Border Grid.Row="2" Background="White" BorderBrush="LightGray" BorderThickness="0,1,0,0" Padding="10">
            <StackPanel Orientation="Horizontal" HorizontalAlignment="Center">
                <Button Content="Закрыть" Click="CloseButton_Click" Width="80" Height="32" Margin="5" Padding="5"
        Style="{StaticResource GrayRoundedButton}"/>
                <Button Content="Экспорт в Excel" Style="{StaticResource RoundedButton}" Click="ExportToExcel_Click" 
         Width="130" Height="32" Margin="5" Padding="5"/>
            </StackPanel>
        </Border>
    </Grid>
</Window>