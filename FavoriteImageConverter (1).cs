using System;
using System.Collections.Generic;
using System.Linq;

namespace IS_GTS.ViewModels
{
    public class ProductItem
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string GostNumber { get; set; }
        public string Category { get; set; }
        public string Material { get; set; }
    }

    public class FilterSetting
    {
        public string ParameterName { get; set; }
        public string Unit { get; set; }
        public double? MinValue { get; set; }
        public double? MaxValue { get; set; }

        public override string ToString()
        {
            return $"{ParameterName}: {MinValue} - {MaxValue} {Unit}";
        }
    }

    public class ColumnSetting
    {
        public string FieldName { get; set; }
        public string DisplayName { get; set; }
        public bool IsVisible { get; set; }
        public bool IsEnabled { get; set; } = true;
        public double Width { get; set; } = 100;

        public string Description => $"Поле: {FieldName}";
    }

    public class AvailableParameter
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string DisplayName => $"{Name} ({Unit})";
    }

    public class ProductCharacteristic
    {
        public int ProductID { get; set; }
        public int SizeID { get; set; }
        
        public string ProductName { get; set; }
        public decimal? NominalValue { get; set; }
        public bool IsFavorite { get; set; }

        public string FolderName { get; set; }
        public bool IsSelectedProfile { get; set; } // для подсветки выбранного профиля


        public Dictionary<string, CharacteristicDetail> Characteristics { get; set; }

        public ProductCharacteristic()
        {
            Characteristics = new Dictionary<string, CharacteristicDetail>();
            IsFavorite = false;

        }
    }

    public class CharacteristicDetail
    {
        public decimal Value { get; set; }
        public string Unit { get; set; }
        public string DisplayValue { get; set; }
    }


    public class FavoriteItem
    {
        public int FavoriteID { get; set; }
        public int SizeID { get; set; }
        public string ProfileName { get; set; }
        public string GostNumber { get; set; }
        public string GostName { get; set; }
        public string Category { get; set; }
        public string Material { get; set; }
        public string CurrentFolder { get; set; }
        public DateTime? AddedDate { get; set; }

        // Для ComboBox с папками
        public List<string> AvailableFolders { get; set; }
    }

    public class FolderItem
    {
        public string Name { get; set; }
        public bool IsUsed { get; set; }
        public int ItemCount { get; set; }

        public override string ToString()
        {
            return $"{Name} ({ItemCount})";
        }
    }


    // Модель для отображения истории
    public class HistoryItem
    {
        public int VisitID { get; set; }
        public DateTime VisitDateTime { get; set; }
        public string GostNumber { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string MaterialName { get; set; }
        public string SearchQuery { get; set; }

        // Свойства для привязки в DataGrid
        public string FormattedDateTime => VisitDateTime.ToString("dd.MM.yyyy HH:mm");
        public string GostName => $"{GostNumber} - {ProductName}";
        public string ElementInfo => $"{CategoryName} ({MaterialName})";
    }
}