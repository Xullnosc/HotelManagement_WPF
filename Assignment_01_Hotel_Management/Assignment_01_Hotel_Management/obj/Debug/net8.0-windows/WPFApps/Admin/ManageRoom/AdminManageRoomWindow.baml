   M S B A M L   `   `   `  ����Y  UAssignment_01_Hotel_Management, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:Assignment_01_Hotel_Management.WPFApps&Assignment_01_Hotel_Management.WPFApps  5   	   B    <Assignment_01_Hotel_Management.WPFApps.AdminManageRoomWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:Assignment_01_Hotel_Management.WPFApps     5   	     � Title$  AdminManageRoomWindow��5   	   $	��450��6'   $	��800��64   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 1Q�6-   � 5      $ 	#FF406DAC��6   $ 0Q�61   5      .+�5   
   �� -   5        $��SearchTextBox��5      $	��200��6'   $��30��63   $	��Top=�6?   $��352,20,248,0q�6W   �� 5   
   -   5        $��Search��5      $��30��6"   $	��Top=�6.   $��518,20,187,0q�6F   6\   &   System.Windows.Controls.DataGrid  5   
   -   5        $��RoomDataGrid��5      $	��232��6'   $	��Top=�64   $��
66,80,69,0q�6L      AutoGenerateColumns$ False��5         SelectionMode$ Single=�6/      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 50 6L   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   �� *RoomID+6L     5      $ Room Number��6%   $		 100 6Y   
 6:   �� *
RoomNumber+6Y     5      $ Description��6%   $		 150 6^   
 6:   �� *RoomDescription+6^     5      $ Capacity��6%   $	 80 6[   
 67   �� *RoomMaxCapacity+6[     5      $ Price Per Date��6%   $		 100 6b   
 6=   �� *RoomPricePerDate+6b     5      $ 	Room Type��6%   $		 100 6b   
 68   �� *RoomType.RoomTypeName+6b     5      $ Status��6%   $	 80 6T   
 65   �� *
RoomStatus+6T   5       �� 5#   
   -   5        $��Add New Room��5#      $��30��6(   $	��Top=�64   $��150,334,546,0q�6L   6c   �� 5$   
   -   5        $��	Edit Room��5$      $��30��6%   $	��Top=�61   $��325,334,388,0q�6I   6`   �� 5%   
   -   5        $��Delete Room��5%      $��30��6'   $	��Top=�63   $��492,334,211,0q�6K   6b   �� 5&   
   $��ROOM MANAGEMENT��6   $
��Left=�6*   $��	66,22,0,0q�6E   $	��Top=�6X   $
��Bold"�6p   �� 5(   
   -   5        $��	Dashboard��5(      $
��Left=�6%   $��
709,19,0,0q�6@   $	��Top=�6T   $��32��6�   5*      5+      