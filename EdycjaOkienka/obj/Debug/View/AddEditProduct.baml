   M S B A M L   `   `   `  ����H  DEdycjaOkienka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:EdycjaOkienka.ViewEdycjaOkienka.View  5   	   A%clr-namespace:EdycjaOkienka.ViewModelEdycjaOkienka.ViewModel  5   	   '    !EdycjaOkienka.View.AddEditProduct   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   2local clr-namespace:EdycjaOkienka.View     5   	   ;	viewModel%clr-namespace:EdycjaOkienka.ViewModel     5   	     � Title$  AddEditProduct��5	   	   $
��Auto��6    $	��300��6.   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Symbol��5      �� 5   
   $��1��5      $��Nazwa��5      �� 5   
   $��2��5       $��Liczba sztuk��5!      �� 5"   
   $��3��5#      $��Magazyn��5$      �� 5&   
   $��1��5'      ��5(      �� *CurrentProduct.Symbol+�� 5)   
   $��1��5*      $��1��5+      ��5,      �� *CurrentProduct.Nazwa+�� 5-   
   $��1��5.      $��2��5/      ��50      �� *CurrentProduct.LiczbaSztuk+�� 51   
   $��1��52      $��3��53      ��54      �� *CurrentProduct.Magazyn+�� 56   
   $��4��57      $��Anuluj��58       �� IsCancel . 59      �� 5:   
   $��1��5;      $��4��5<      $��Zapisz��5=      ��5>      �� *
BtnAddEdit+5?      5@      