<Window x:Class="IS_GTS.Windows.FiltersWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:IS_GTS.Windows"
        mc:Ignorable="d"
        Title="Настройка таблицы и фильтров" 
        Height="500" Width="600"
        WindowStartupLocation="CenterScreen"
        ResizeMode="NoResize" Background="#FFFFFFF6">

    <Grid Margin="15">
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="30"/>
        </Grid.RowDefinitions>

        <!-- Динамические фильтры -->
        <GroupBox Grid.Row="0" Header="Добавление параметров фильтрации" x:Name="FilterGroupBox">
            <StackPanel>
                <!-- Существующие фильтры -->
                <ItemsControl x:Name="ActiveFiltersItemsControl" Margin="0,0,0,10">
                    <ItemsControl.ItemTemplate>
                        <DataTemplate>
                            <Border BorderBrush="LightGray" BorderThickness="0,0,0,1" 
                                    Padding="0,5" Margin="0,0,0,5">
                                <Grid>
                                    <Grid.ColumnDefinitions>
                                        <ColumnDefinition Width="*"/>
                                        <ColumnDefinition Width="Auto"/>
                                    </Grid.ColumnDefinitions>

                                    <TextBlock Text="{Binding}" VerticalAlignment="Center"/>
                                    <Button Grid.Column="1" Content="✕" Padding="5,2" 
                                            Tag="{Binding ParameterName}"
                                            Click="RemoveFilter_Click"/>
                                </Grid>
                            </Border>
                        </DataTemplate>
                    </ItemsControl.ItemTemplate>
                </ItemsControl>

                <!-- Добавление нового -->
                <Grid>
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="150"/>
                        <ColumnDefinition Width="Auto"/>
                        <ColumnDefinition Width="80"/>
                        <ColumnDefinition Width="Auto"/>
                        <ColumnDefinition Width="80"/>
                        <ColumnDefinition Width="Auto"/>
                        <ColumnDefinition Width="*"/>
                    </Grid.ColumnDefinitions>

                    <ComboBox Grid.Column="0" x:Name="NewParameterComboBox"
                             DisplayMemberPath="DisplayName"
                             SelectionChanged="NewParameterComboBox_SelectionChanged"/>

                    <TextBlock Grid.Column="1" Text="от:" VerticalAlignment="Center" Margin="10,0,5,0"/>
                    <TextBox Grid.Column="2" x:Name="MinValueTextBox"/>

                    <TextBlock Grid.Column="3" Text="до:" VerticalAlignment="Center" Margin="10,0,5,0"/>
                    <TextBox Grid.Column="4" x:Name="MaxValueTextBox"/>

                    <TextBlock Grid.Column="5" x:Name="UnitTextBlock" VerticalAlignment="Center" 
                              Margin="5,0,10,0" FontWeight="Bold"/>

                    <Button Grid.Column="6"  Content="+ Добавить" Click="AddFilter_Click" Padding="10,5"
        Background="#E0E0E0" Foreground="Black" BorderBrush="Transparent" BorderThickness="0">
                        <Button.Template>
                            <ControlTemplate TargetType="Button">
                                <Border Background="{TemplateBinding Background}"
                    BorderBrush="{TemplateBinding BorderBrush}"
                    BorderThickness="{TemplateBinding BorderThickness}"
                    CornerRadius="4">
                                    <ContentPresenter HorizontalAlignment="Center" VerticalAlignment="Center"/>
                                </Border>
                                <ControlTemplate.Triggers>
                                    <Trigger Property="IsMouseOver" Value="True">
                                        <Setter Property="Background" Value="#C0C0C0"/>
                                    </Trigger>
                                </ControlTemplate.Triggers>
                            </ControlTemplate>
                        </Button.Template>
                    </Button>
                </Grid>
            </StackPanel>
        </GroupBox>

        <!-- Настройка колонок -->
        <GroupBox Grid.Row="2" Header="Отображаемые колонки" Margin="0,10,0,0" x:Name="ColumnSettingsGroupBox">
            <StackPanel>
                <!-- Чекбокс "Показать все" -->
                <CheckBox x:Name="SelectAllCheckBox" 
                  Content="Показать все" 
                  Margin="10,5,10,10"
                  FontWeight="Bold"
                  Checked="SelectAllCheckBox_Checked"
                  Unchecked="SelectAllCheckBox_Unchecked"
                  ToolTip="Отметить/снять все колонки"/>

                <Separator Margin="0,0,0,5"/>

                <!-- Список чекбоксов характеристик -->
                <ItemsControl x:Name="ColumnSettingsItemsControl">
                    <ItemsControl.ItemsPanel>
                        <ItemsPanelTemplate>
                            <WrapPanel Orientation="Horizontal"/>
                        </ItemsPanelTemplate>
                    </ItemsControl.ItemsPanel>
                    <ItemsControl.ItemTemplate>
                        <DataTemplate>
                            <CheckBox Content="{Binding DisplayName}" Margin="10,5"
                             IsChecked="{Binding IsVisible}"
                             Checked="ColumnCheckBox_Checked"
                             Unchecked="ColumnCheckBox_Unchecked"
                             ToolTip="{Binding Description}"/>
                        </DataTemplate>
                    </ItemsControl.ItemTemplate>
                </ItemsControl>
            </StackPanel>
        </GroupBox>

        <!-- Кнопки -->
        <StackPanel Grid.Row="4" Orientation="Horizontal" HorizontalAlignment="Right">
            <Button Content="Сбросить всё" Width="90" Click="ResetAll_Click" 
         Style="{StaticResource GrayRoundedButton}"/>
            <Button Content="Применить" Margin="10,0,0,0" 
                   Click="ApplySettings_Click" IsDefault="True"
                   Style="{StaticResource RoundedButton}" Width="74"/>
        </StackPanel>
    </Grid>
</Window>