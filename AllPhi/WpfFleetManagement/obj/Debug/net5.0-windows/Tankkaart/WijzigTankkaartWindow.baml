   M S B A M L   `   `   `  ����M  IWpfFleetManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:WpfFleetManagement.TankkaartWpfFleetManagement.Tankkaart  5   	   8    2WpfFleetManagement.Tankkaart.WijzigTankkaartWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:WpfFleetManagement.Tankkaart     5   	     � Title$  WijzigTankkaartWindow��5   	   $	��600��6'   $
��1000��64   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��75 �6   �� 5      $��75 �6   �� 5      $��75 �6   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��0��6   $��0��6    $��Kaartnummer��6-   $��5q�6C   �� 5   
   -   5         ��Name$ TextBoxKaartnummer��5      $��0��6.   $��0��6;   $��	5,30,5,10q�6L   �� 5   
   $��1��6   $��0��6    $��Geldigheidsdatum��6-   $��5q�6H   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$  DatePickerGeldigheidsDatum��5      $��0��69   $��1��6F   $��	5,30,5,10q�6W   �� 5   
   $��0��6   $��2��6    $��Pincode��6-   $��5q�6?   �� 5   
   -   5        $ TextBoxPincode��5      $��0��6*   $��2��6:   $��	5,30,5,10q�6G   �� 5    
   $��1��6   $��2��6    $��Geblokkeerd?��6-   $��5q�6D   $��Center=�6O   �� 5!   
   -   5         ��Name$ CheckBoxGeblokkeerd��5!      $��2��60   $��1��6=   $��Center=�6M   $��Center=�6h   �� 5#   
   $��0��6   $��4��6    $��	Brandstof��6-   $��5q�6A   �� 5$   
   -   5         ��Name$ ComboBoxBrandstof��5$      $��4��6.   $��0��6;   $��	5,30,5,10q�6L   6_   �� 5&   
   $��1��6   $��4��6    $��
Bestuurder��6-   $��5q�6B   �� 5'   
   -   5        $ TextBoxBestuurder��5'      $��1��6-   $��4��6=   $��	5,30,5,10q�6J   ${�False��6]   �� 5)   
   -   5         ��Name$ BestuurderButton��5)      $��1��6+   $��3��6;   $��Kies Bestuurder��6H   $��5q�6b   6m   �� 5*   
   -   5        $ VerwijderBestuurderButton��5*      $��1��64   $��5��6D   $��Verwijder Bestuurder��6Q   $��5q�6p   6{   �� 5,   
   -	   5        $ WijzigButton��5,      $��2��6B   $��6��6V   $��5q�6c   .��6n   Wijzig6v   5-      5.      