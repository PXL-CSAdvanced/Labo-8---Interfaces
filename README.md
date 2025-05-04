# Labo 8 - Interfaces

## Doel
In dit labo maken we een applicatie die zal worden gebruikt in door de PXL PC-shop.  Nadat de naam van de klant wordt ingegeven en het gewenste product wordt geselecteerd moet de gebruiker een betaalwijze selecteren. Afhankelijk van de gekozen waarde zal de gepaste procedure worden uitgevoerd wanneer er op de *Checkout* knop geklikt wordt.

![screenshot](media/wpf.png)

## UI
Gebruik de volgende eigenschappen voor het MainWindow:
- Titel: PXL PC Shop - Powered by EasyCheckout
- Hoogte: 500
- Breedte: 550
- Lettertype: Lucida Console
- Lettergrootte: 14

**Gebruik de XAML-code helemaal onderaan als inhoud voor het MainWindow en voorzie de juiste event-procedures in het code-behind bestand.**

## Entities


## Data


## Logger



## MainWindow.xaml
```
<DockPanel>
    <Menu DockPanel.Dock="Top">
        <MenuItem Header="Bestelling">
            <MenuItem Header="Nieuw" Click="OnNewOrder_Clicked"/>
        </MenuItem>
    </Menu>    
    
    <StackPanel>
        <GroupBox Header="Bestelling" Margin="10" Padding="10">
            <StackPanel>
                <Label Content="Klant:" Margin="5"/>
                <TextBox x:Name="customerTextBox" Margin="5" Padding="3"/>
                <Label Content="Product:" Margin="5"/>
                <ComboBox x:Name="productsComboBox" Margin="5" SelectionChanged="OnProduct_SelectionChanged"/>
            </StackPanel>
        </GroupBox>
        <GroupBox Header="Betaling" Margin="10" Padding="10">
            <StackPanel>
                <Grid>
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition/>
                        <ColumnDefinition Width="Auto"/>
                    </Grid.ColumnDefinitions>
                    <Label Content="Totaal: " Margin="5"/>
                    <Label Grid.Column="1" x:Name="amountLabel" Margin="5"/>
                </Grid>
                <Label Content="Selecteer uw betaalmethode:" Margin="5"/>
                <ComboBox Margin="5" x:Name="paymentMethodComboBox"/>
                <Button HorizontalAlignment="Right" Content="Checkout" Margin="5" Padding="6" Click="OnCheckout_Clicked"/>
                <TextBlock x:Name="paymentResultTextBlock" Margin="5" TextWrapping="Wrap" Background="Black" Foreground="White" Padding="5"/>
            </StackPanel>
        </GroupBox>
    </StackPanel>
</DockPanel>
```