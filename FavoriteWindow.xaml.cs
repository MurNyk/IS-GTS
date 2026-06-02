<Window x:Class="IS_GTS.Windows.FavoriteWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:IS_GTS.Windows"
        mc:Ignorable="d"
        WindowStartupLocation="CenterScreen"
        Title="Избранное" Height="530" Width="1100" Background="#FFFFFFF6">

    <Grid Margin="10">
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>

        <!-- Верхняя панель -->
        <Border Grid.Row="0" Margin="0,0,0,10">
            <StackPanel Orientation="Horizontal">
                <TextBlock Text="Избранные профили" FontSize="16" FontWeight="Bold"/>
                <TextBlock x:Name="CountText" Text="(0 профилей)" Margin="10,0,0,0" VerticalAlignment="Center"/>
            </StackPanel>
        </Border>

        <!-- Основная область -->
        <Grid Grid.Row="1">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="*"/>
                <ColumnDefinition Width="250"/>
            </Grid.ColumnDefinitions>

            <!-- Таблица с избранным -->
            <DataGrid x:Name="FavoritesDataGrid" Grid.Column="0" 
                      AutoGenerateColumns="False" 
                      CanUserAddRows="False" 
                      IsReadOnly="True"
                      Margin="0,0,10,0">
                <DataGrid.Columns>
                    <DataGridTextColumn Header="Профиль" Binding="{Binding ProfileName}" Width="120"/>
                    <DataGridTextColumn Header="ГОСТ" Binding="{Binding GostNumber}" Width="100"/>
                    <DataGridTextColumn Header="Материал" Binding="{Binding Material}" Width="100"/>
                    <DataGridTextColumn Header="Категория" Binding="{Binding Category}" Width="120"/>

                    <DataGridTemplateColumn Header="Папка" Width="140">
                        <DataGridTemplateColumn.CellTemplate>
                            <DataTemplate>
                                <ComboBox ItemsSource="{Binding AvailableFolders}" 
                                          SelectedItem="{Binding CurrentFolder, Mode=TwoWay}"
                                          Width="130" Height="22"
                                          SelectionChanged="FolderComboBox_SelectionChanged">
                                    <ComboBox.ItemTemplate>
                                        <DataTemplate>
                                            <TextBlock Text="{Binding}"/>
                                        </DataTemplate>
                                    </ComboBox.ItemTemplate>
                                </ComboBox>
                            </DataTemplate>
                        </DataGridTemplateColumn.CellTemplate>
                    </DataGridTemplateColumn>

                    <DataGridTextColumn Header="Добавлен" Binding="{Binding AddedDate, StringFormat='dd.MM.yyyy'}" Width="90"/>

                    <DataGridTemplateColumn Header="Действия" Width="*">
                        <DataGridTemplateColumn.CellTemplate>
                            <DataTemplate>
                                <StackPanel Orientation="Horizontal">
                                    <Button Content="Открыть" Tag="{Binding GostNumber}" 
                                            Click="OpenGostButton_Click" Width="50" Margin="2" HorizontalAlignment="Center"/>
                                    <Button Content="Удалить" Tag="{Binding FavoriteID}" 
                                            Click="RemoveButton_Click" Width="50" Margin="2" HorizontalAlignment="Center"/>
                                </StackPanel>
                            </DataTemplate>
                        </DataGridTemplateColumn.CellTemplate>
                    </DataGridTemplateColumn>
                </DataGrid.Columns>
            </DataGrid>

            <!-- Правая панель с папками -->
            <Border Grid.Column="1" Background="#F5F5F5" CornerRadius="8" Padding="10">
                <StackPanel>
                    <TextBlock Text="Управление папками" FontWeight="Bold" Margin="0,0,0,10"/>

                    <TextBlock Text="Создать папку:" Margin="0,0,0,5"/>
                    <StackPanel Orientation="Horizontal">
                        <TextBox x:Name="NewFolderTextBox" Width="196" Height="25" Margin="0,0,5,0"
         BorderBrush="Gray" BorderThickness="1">
                            <TextBox.Template>
                                <ControlTemplate TargetType="TextBox">
                                    <Border BorderBrush="{TemplateBinding BorderBrush}"
                    BorderThickness="{TemplateBinding BorderThickness}"
                    CornerRadius="2"
                    Background="{TemplateBinding Background}">
                                        <ScrollViewer x:Name="PART_ContentHost" Margin="2"/>
                                    </Border>
                                </ControlTemplate>
                            </TextBox.Template>
                        </TextBox>
                        <Button Content="+" Click="CreateFolderButton_Click" Width="30" Height="25" 
        Style="{StaticResource GrayRoundedButton}"/>
                    </StackPanel>

                    <TextBlock Text="Существующие папки:" Margin="0,15,0,5"/>
                    <ListBox x:Name="FoldersListBox" Height="200" 
         SelectionChanged="FoldersListBox_SelectionChanged"
         BorderBrush="LightGray" BorderThickness="1">
                        <ListBox.Resources>
                            <Style TargetType="ListBoxItem">
                                <Setter Property="Template">
                                    <Setter.Value>
                                        <ControlTemplate TargetType="ListBoxItem">
                                            <Border CornerRadius="4" Background="{TemplateBinding Background}" Padding="4">
                                                <ContentPresenter/>
                                            </Border>
                                        </ControlTemplate>
                                    </Setter.Value>
                                </Setter>
                            </Style>
                        </ListBox.Resources>
                        <ListBox.Template>
                            <ControlTemplate TargetType="ListBox">
                                <Border BorderBrush="{TemplateBinding BorderBrush}"
                    BorderThickness="{TemplateBinding BorderThickness}"
                    CornerRadius="4"
                    Background="White">
                                    <ScrollViewer Focusable="false" Padding="2">
                                        <ItemsPresenter/>
                                    </ScrollViewer>
                                </Border>
                            </ControlTemplate>
                        </ListBox.Template>
                        <ListBox.ItemTemplate>
                            <DataTemplate>
                                <StackPanel Orientation="Horizontal" Margin="0,2">
                                    <TextBlock Text="{Binding Name}" Width="120"/>
                                    <TextBlock Text="(" Foreground="Gray"/>
                                    <TextBlock Text="{Binding ItemCount}" Foreground="Gray"/>
                                    <TextBlock Text=")" Foreground="Gray"/>
                                    <Button Content="✖" 
                        Width="20" Height="20"
                        Click="DeleteFolderButton_Click"
                        Tag="{Binding Name}"
                        Foreground="Red"
                        Background="Transparent"
                        BorderThickness="0"
                        Margin="5,0,0,0"/>
                                </StackPanel>
                            </DataTemplate>
                        </ListBox.ItemTemplate>
                    </ListBox>

                    <Button x:Name="ShowAllButton" Content="Показать все" Click="ShowAllButton_Click" 
        Height="30" Margin="0,10,0,0" Style="{StaticResource GrayRoundedButton}"/>


                    <TextBlock x:Name="StatsText" Text="" Margin="0,15,0,0" Foreground="Gray"/>
                </StackPanel>
            </Border>
        </Grid>
    </Grid>
</Window>