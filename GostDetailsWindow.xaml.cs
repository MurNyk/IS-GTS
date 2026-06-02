<!-- GostDetailsWindow.xaml -->
<Window x:Class="IS_GTS.Windows.GostDetailsWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:IS_GTS.Windows"
        mc:Ignorable="d"
        Title="Детальное описание стандарта" Height="650" Width="1200" WindowStartupLocation="CenterScreen" Background="#FFFFFFF6">

    <Window.Resources>
        <Style x:Key="SelectedProfileRowStyle" TargetType="DataGridRow">
            <Style.Triggers>
                <DataTrigger Binding="{Binding IsSelectedProfile}" Value="True">
                    <Setter Property="Background" Value="#FFE6F0FF"/>
                    <Setter Property="FontWeight" Value="Bold"/>
                    <Setter Property="BorderBrush" Value="#FF3399FF"/>
                    <Setter Property="BorderThickness" Value="2"/>
                </DataTrigger>
            </Style.Triggers>
        </Style>
    </Window.Resources>

    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
            <RowDefinition Height="Auto"/>
        </Grid.RowDefinitions>

        <Grid Grid.Row="0">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="*"/>
                <ColumnDefinition Width="Auto"/>
            </Grid.ColumnDefinitions>

            <StackPanel Grid.Column="0">
                <TextBlock x:Name="GostTitleText" Text="Название ГОСТа" Margin="10,5,0,0"/>
                <TextBlock x:Name="GostNumber" Text="Номер ГОСТа" Margin="10,5,0,0"/>
                <TextBlock x:Name="ProductsCountText" Text="Загрузка..." Margin="10,5,0,0"/>
            </StackPanel>

            <Button Grid.Column="1" Content="Закрыть" Width="90" Height="30" Margin="0,0,15,0" Click="Button_Click"
                    Style="{StaticResource GrayRoundedButton}"/>
        </Grid>

        <Grid Grid.Row="1">
            <Grid.RowDefinitions>
                <RowDefinition Height="Auto"/>
                <RowDefinition Height="*"/>
            </Grid.RowDefinitions>

            <Grid Grid.Row="0">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="Auto"/>
                    <ColumnDefinition Width="Auto"/>
                    <ColumnDefinition Width="Auto"/>
                </Grid.ColumnDefinitions>

                <StackPanel Grid.Row="0" Grid.Column="0" Orientation="Horizontal" Margin="20,10,0,0">
                    <TextBlock Text="Поиск:" VerticalAlignment="Center"/>
                    <TextBox x:Name="SearchTextBox" Width="200" KeyDown="SearchTextBox_KeyDown"/>
                    <Button x:Name="SearchButton" Content="Найти" Width="70" Style="{StaticResource RoundedButton}" Click="SearchButton_Click"/>
                </StackPanel>

                <Button Grid.Column="1" x:Name="ToggleDrawingButton" Width="100"
        Content="Скрыть чертеж" 
        Height="25" Margin="100,5,0,0"
        Click="ToggleDrawingButton_Click"
        ToolTip="Скрыть/показать чертеж"  Style="{StaticResource GrayRoundedButton}"/>

                <Button Grid.Column="2" x:Name="SettingButton" Content="Настроить таблицу" 
        Width="120" Height="25" Margin="200,10,0,0" Click="SettingButton_Click"
        Style="{StaticResource GrayRoundedButton}"/>
            </Grid>

            <Grid Grid.Row="1">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition x:Name="DrawingColumn" Width="350"/>
                    <ColumnDefinition Width="*"/>
                </Grid.ColumnDefinitions>

                <Grid Grid.Column="0" x:Name="DrawingPanel" Margin="10,20,5,0">
                    <Grid.RowDefinitions>
                        <RowDefinition Height="*"/>
                        <RowDefinition Height="Auto"/>
                    </Grid.RowDefinitions>

                    <Border Grid.Row="0" BorderBrush="LightGray" BorderThickness="1">
                        <Grid x:Name="ImageGrid">
                            <ScrollViewer VerticalScrollBarVisibility="Auto" HorizontalScrollBarVisibility="Auto">
                                <Image x:Name="GostDrawingImage" 
                                      Stretch="Uniform" 
                                      HorizontalAlignment="Center" 
                                      VerticalAlignment="Center"/>
                            </ScrollViewer>

                            <Border x:Name="ToolsPanel"
                                    HorizontalAlignment="Right" VerticalAlignment="Bottom"
                                    Margin="10" Visibility="Visible">

                                <!--<StackPanel Orientation="Vertical" Margin="5">
                                    --><!--<Button Content="+" Width="30" Height="30" ToolTip="Увеличить" Click="ZoomIn_Click"/>
                                    <Button Content="-" Width="30" Height="30" ToolTip="Уменьшить" Click="ZoomOut_Click"/>
                                    <Button Content="100%" Width="30" Height="30" ToolTip="Сбросить масштаб" Click="ZoomReset_Click"/>--><!--
                                </StackPanel>-->
                            </Border>
                        </Grid>
                    </Border>
                </Grid>

                <Grid Grid.Column="1" Margin="0,20,10,0">
                    <DataGrid x:Name="GostDataGrid" 
                              AutoGenerateColumns="False"
                              CanUserAddRows="False"
                              CanUserDeleteRows="False"
                              CanUserResizeColumns="True"
                              CanUserResizeRows="False"
                              CanUserSortColumns="True"
                              CanUserReorderColumns="True"
                              SelectionMode="Single"
                              SelectionUnit="FullRow"
                              MouseDoubleClick="GostDataGrid_MouseDoubleClick"
                              GridLinesVisibility="All"
                              RowStyle="{StaticResource SelectedProfileRowStyle}"/>
                </Grid>
            </Grid>
        </Grid>

        <Grid Grid.Row="2">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="*"/>
                <ColumnDefinition Width="Auto"/>
            </Grid.ColumnDefinitions>

            <TextBlock Grid.Column="0" VerticalAlignment="Center">
                <Run Text="Колонок:"/>
                <Run x:Name="ColumnsCountText" Text="0"/>
                <Run Text="Строк:"/>
                <Run x:Name="RowsCountText" Text="0"/>
            </TextBlock>

            <TextBlock Grid.Column="1" VerticalAlignment="Center" Margin="0,0,10,0">
                <Run Text="Чертеж:"/>
                <Run x:Name="DrawingStatusText" Text="показан"/>
            </TextBlock>
        </Grid>
    </Grid>
</Window>