   M S B A M L   `   `   `  ����G  CFirstProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:FirstProjectFirstProject  5   	       FirstProject.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:FirstProject     5   	   -   5          � Title$  
MainWindow��5   	   $��363.056��6   $��462.793��6-   
�������.��5	      � $��10q�6    � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� -   5        $��btnAdd��5      $��Öğrenci Ekle��6   ���	#FFE6DCD3$��29,262,20,10q�6M   $��Segoe UI Emoji)�6x   $��24(�6�   $��1��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��tablo��5      $��71��6    $��
19,21,20,0q�6,   $��1��6@      AutoGenerateColumns .  $	��Top=�6l   ���	#FFB0B0B0
���   �$��16(�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Ad��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Ad+  5      $ Soyad��6%    64   �� *Soyad+  5      $ Cinsiyet��6%    67   �� *
Cinsiyet+  5      $ Öğrenci No��6%    69   �� *	OgrenciNo+  5      $ Bölüm��6%    64   �� *Bolum+5      �� 5   
   $)��#Görsel Programlama III Vize Ödevi��6   $��1��6<   $
��Left=�6L   $��
29,148,0,0q�6g   $	��Top=�6{   ���	#FFFFD9D9
���   �$��Stencil)�6�   $��20(�6�   $	��386��6�   5      5      