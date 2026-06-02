<?xml version="1.0" encoding="utf-8"?>
<edmx:Edmx Version="3.0" xmlns:edmx="http://schemas.microsoft.com/ado/2009/11/edmx">
 <!-- EF Designer content (DO NOT EDIT MANUALLY BELOW HERE) -->
  <edmx:Designer xmlns="http://schemas.microsoft.com/ado/2009/11/edmx">
    <!-- Diagram content (shape and connector positions) -->
    <edmx:Diagrams>
      <Diagram DiagramId="ee5c08fcce764f6db705eecdde20de7c" Name="Diagram1">
        <EntityTypeShape EntityType="DiplomMurModel.Category" Width="1.5" PointX="3" PointY="4.5" IsExpanded="true" />
        <EntityTypeShape EntityType="DiplomMurModel.Characteristic" Width="1.5" PointX="7.5" PointY="8.875" IsExpanded="true" />
        <EntityTypeShape EntityType="DiplomMurModel.CharacteristicValue" Width="1.5" PointX="9.75" PointY="4.375" IsExpanded="true" />
        <EntityTypeShape EntityType="DiplomMurModel.Favorite" Width="1.5" PointX="12.75" PointY="4.75" IsExpanded="true" />
        <EntityTypeShape EntityType="DiplomMurModel.Material" Width="1.5" PointX="0.75" PointY="5.125" IsExpanded="true" />
        <EntityTypeShape EntityType="DiplomMurModel.Product" Width="1.5" PointX="5.25" PointY="4.5" IsExpanded="true" />
        <EntityTypeShape EntityType="DiplomMurModel.Role" Width="1.5" PointX="3" PointY="9.25" IsExpanded="true" />
        <EntityTypeShape EntityType="DiplomMurModel.Size" Width="1.5" PointX="7.5" PointY="4.625" IsExpanded="true" />
        <EntityTypeShape EntityType="DiplomMurModel.User" Width="1.5" PointX="5.25" PointY="8.25" IsExpanded="true" />
        <EntityTypeShape EntityType="DiplomMurModel.VisitHistory" Width="1.5" PointX="7.5" PointY="0.75" IsExpanded="true" />
        <AssociationConnector Association="DiplomMurModel.FK_Category_Category" ManuallyRouted="false" />
        <AssociationConnector Association="DiplomMurModel.FK_Category_Material" ManuallyRouted="false" />
        <AssociationConnector Association="DiplomMurModel.FK_Product_Category" ManuallyRouted="false" />
        <AssociationConnector Association="DiplomMurModel.FK_CharacteristicValue_Characteristic" ManuallyRouted="false" />
        <AssociationConnector Association="DiplomMurModel.FK_CharacteristicValue_Size" ManuallyRouted="false" />
        <AssociationConnector Association="DiplomMurModel.FK_Favorite_Size" ManuallyRouted="false" />
        <AssociationConnector Association="DiplomMurModel.FK_Favorite_User" ManuallyRouted="false" />
        <AssociationConnector Association="DiplomMurModel.FK_Size_Product" ManuallyRouted="false" />
        <AssociationConnector Association="DiplomMurModel.FK_VisitHistory_Product" ManuallyRouted="false" />
        <AssociationConnector Association="DiplomMurModel.FK_User_Role" ManuallyRouted="false" />
        <AssociationConnector Association="DiplomMurModel.FK_VisitHistory_User" ManuallyRouted="false" />
      </Diagram>
    </edmx:Diagrams>
  </edmx:Designer>
</edmx:Edmx>