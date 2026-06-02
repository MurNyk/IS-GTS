<Window x:Class="IS_GTS.Windows.ComparisonWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Сравнение профилей" Height="650" Width="1200"
        WindowStartupLocation="CenterScreen" Background="#FFFFFFF6">

    <Window.Resources>
        <Style TargetType="DataGridColumnHeader">
            <Setter Property="Background" Value="#F0F0F0"/>
            <Setter Property="FontWeight" Value="SemiBold"/>
            <Setter Property="BorderBrush" Value="LightGray"/>
            <Setter Property="BorderThickness" Value="0,0,1,1"/>
            <Setter Property="Padding" Value="8,4"/>
            <Setter Property="HorizontalContentAlignment" Value="Center"/>
        </Style>

        <Style TargetType="DataGridCell">
            <Setter Property="BorderBrush" Value="LightGray"/>
            <Setter Property="BorderThickness" Value="0,0,1,1"/>
            <Setter Property="Padding" Value="6,2"/>
            <Setter Property="VerticalAlignment" Value="Center"/>
            <Setter Property="HorizontalAlignment" Value="Center"/>
            <Setter Property="TextBlock.TextAlignment" Value="Center"/>
            <Setter Property="FontSize" Value="12"/>
        </Style>

        <Style TargetType="DataGridRow">
            <Setter Property="Background" Value="White"/>
            <Setter Property="Height" Value="35"/>
            <Style.Triggers>
                <Trigger Property="IsMouseOver" Value="True">
                    <Setter Property="Background" Value="#E6F0FF"/>
                </Trigger>
            </Style.Triggers>
        </Style>

        <!-- Стиль для серых кнопок -->
        <Style x:Key="GrayRoundedButton" TargetType="Button">
            <Setter Property="Background" Value="#E0E0E0"/>
            <Setter Property="Foreground" Value="Black"/>
            <Setter Property="BorderBrush" Value="Transparent"/>
            <Setter Property="BorderThickness" Value="0"/>
            <Setter Property="Cursor" Value="Hand"/>
            <Setter Property="Template">
                <Setter.Value>
                    <ControlTemplate TargetType="Button">
                        <Border Background="{TemplateBinding Background}"
                                BorderBrush="{TemplateBinding BorderBrush}"
                                BorderThickness="{TemplateBinding BorderThickness}"
                                CornerRadius="4">
                            <ContentPresenter HorizontalAlignment="Center" 
                                              VerticalAlignment="Center"/>
                        </Border>
                        <ControlTemplate.Triggers>
                            <Trigger Property="IsMouseOver" Value="True">
                                <Setter Property="Background" Value="#C0C0C0"/>
                            </Trigger>
                            <Trigger Property="IsPressed" Value="True">
                                <Setter Property="Background" Value="#A0A0A0"/>
                            </Trigger>
                            <Trigger Property="IsEnabled" Value="False">
                                <Setter Property="Background" Value="#F0F0F0"/>
                                <Setter Property="Foreground" Value="#909090"/>
                            </Trigger>
                        </ControlTemplate.Triggers>
                    </ControlTemplate>
                </Setter.Value>
            </Setter>
        </Style>
    </Window.Resources>

    <Grid Margin="10">
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>

        <!-- Верхняя панель с заголовком и кнопкой Закрыть -->
        <Grid Grid.Row="0" Margin="0,0,0,10">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="*"/>
                <ColumnDefinition Width="Auto"/>
            </Grid.ColumnDefinitions>
            <TextBlock Grid.Column="0" Text="Сравнение профилей" 
                       FontSize="16" FontWeight="Bold" VerticalAlignment="Center"/>
            <Button Grid.Column="1" Content="Закрыть" 
                    Click="CloseButton_Click" Width="80" Height="30"
                    Style="{StaticResource GrayRoundedButton}"/>
        </Grid>

        <!-- Основная область -->
        <Grid Grid.Row="1">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="300"/>
                <ColumnDefinition Width="*"/>
            </Grid.ColumnDefinitions>

            <Grid.RowDefinitions>
                <RowDefinition Height="*"/>
                <RowDefinition Height="Auto"/>
            </Grid.RowDefinitions>

            <!-- Левая панель: фильтры и список ГОСТов -->
            <Border Grid.Column="0" Grid.Row="0" Background="#F9F9F9" CornerRadius="8" 
                    BorderBrush="LightGray" BorderThickness="1" Margin="0,0,10,0">
                <StackPanel Margin="10">
                    <TextBlock Text="Выберите ГОСТ" FontSize="14" FontWeight="Bold" Margin="0,0,0,10"/>

                    <TextBlock Text="Материал:" Margin="0,5,0,0"/>
                    <ComboBox x:Name="MaterialComboBox" Height="28" Margin="0,2,0,10"/>

                    <TextBlock Text="Категория:" Margin="0,5,0,0"/>
                    <ComboBox x:Name="CategoryComboBox" Height="28" Margin="0,2,0,10"/>

                    <TextBlock Text="ГОСТ:" FontWeight="Bold" Margin="0,10,0,5"/>
                    <ListBox x:Name="GostListBox" Height="350" 
                             SelectionChanged="GostListBox_SelectionChanged">
                        <ListBox.ItemTemplate>
                            <DataTemplate>
                                <TextBlock Text="{Binding}" Margin="5" TextWrapping="Wrap"/>
                            </DataTemplate>
                        </ListBox.ItemTemplate>
                    </ListBox>
                </StackPanel>
            </Border>

            <!-- Правая панель: таблица профилей -->
            <Border Grid.Column="1" Grid.Row="0" Background="#F9F9F9" CornerRadius="8" 
                    BorderBrush="LightGray" BorderThickness="1">
                <Grid Margin="10">
                    <Grid.RowDefinitions>
                        <RowDefinition Height="Auto"/>
                        <RowDefinition Height="*"/>
                        <RowDefinition Height="Auto"/>
                    </Grid.RowDefinitions>

                    <TextBlock x:Name="SelectedGostTitle" Grid.Row="0" 
                               Text="Выберите ГОСТ из списка слева" 
                               FontSize="14" FontWeight="SemiBold" Margin="0,0,0,10"/>

                    <DataGrid x:Name="ProfilesDataGrid" 
                              Grid.Row="1"
                              AutoGenerateColumns="False"
                              CanUserAddRows="False"
                              CanUserDeleteRows="False"
                              CanUserResizeColumns="False"
                              CanUserSortColumns="True"
                              GridLinesVisibility="All"
                              IsReadOnly="False"
                              SelectionMode="Single"
                              SelectionUnit="FullRow"
                              RowHeaderWidth="0"
                              HeadersVisibility="Column"
                              FrozenColumnCount="2"
                              HorizontalAlignment="Left"
                              VerticalScrollBarVisibility="Auto"
                              HorizontalScrollBarVisibility="Auto"
                              MinHeight="300"
                              MinWidth="650">
                        <DataGrid.Columns>
                            <DataGridCheckBoxColumn Header="Выбрать" 
                                    Binding="{Binding IsSelected, UpdateSourceTrigger=PropertyChanged, Mode=TwoWay}"
                                    Width="60"
                                    IsReadOnly="False"/>
                            <DataGridTextColumn Header="Профиль" 
                                    Binding="{Binding ProductName}"
                                    Width="180"
                                    IsReadOnly="True"/>
                        </DataGrid.Columns>
                    </DataGrid>

                    <!-- Нижняя панель с кнопками действий -->
                    <Border Grid.Row="2" Background="White" BorderBrush="LightGray" 
                            BorderThickness="0,1,0,0" Padding="10" Margin="0,10,0,0">
                        <StackPanel Orientation="Horizontal" HorizontalAlignment="Stretch">
                            <TextBlock x:Name="SelectionInfoText" Text="Выбрано: 0 из 3 (максимум)" 
                                       VerticalAlignment="Center" Margin="180,0,20,0"
                                       FontSize="12" FontWeight="SemiBold"/>

                            <Button x:Name="ClearButton" 
                                    Content="Очистить" 
                                    Click="ClearSelectionButton_Click" 
                                    Width="80" Height="32" 
                                    Margin="0,0,10,0"
                                    Style="{StaticResource GrayRoundedButton}"/>

                            <Button x:Name="CompareButton" 
                                    Content="Сравнить выбранные" 
                                    Click="CompareButton_Click" 
                                    Width="140" Height="32" 
                                    Margin="5"
                                   Style="{StaticResource RoundedButton}"/>
                        </StackPanel>
                    </Border>
                </Grid>
            </Border>
        </Grid>
    </Grid>
</Window>