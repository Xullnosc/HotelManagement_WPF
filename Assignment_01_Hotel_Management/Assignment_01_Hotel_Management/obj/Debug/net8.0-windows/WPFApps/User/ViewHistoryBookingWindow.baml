   M S B A M L   `   `   `  ����Y  UAssignment_01_Hotel_Management, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:Assignment_01_Hotel_Management.WPFApps.User+Assignment_01_Hotel_Management.WPFApps.User  5   	   J    DAssignment_01_Hotel_Management.WPFApps.User.ViewHistoryBookingWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Klocal9clr-namespace:Assignment_01_Hotel_Management.WPFApps.User     5   	     � Title$  ViewHistoryBookingWindow��5   	   $	��450��6*   $	��800��67   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 1Q�6-   � 5      $ 	#FF1B1D78��6   $ 0Q�61   5      .+�5   
   �� $��Booking History��6   $��20(�6+   $
��Bold"�69   $��Center=�6K   $��10q�6h   &   System.Windows.Controls.DataGrid  5   
   -   5        $��BookingDataGrid��5         AutoGenerateColumns$ False��6*   $��10,50,10,10q�6F   $��Stretch=�5      $��Stretch=�61   ���	#FFEFF4F4   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Booking ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6W   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 69   �� *	BookingID+6W     5      $ Room Number��6%   $	 100 6^   	 6:   �� *Room.RoomNumber+6^     5      $ Check-in Date��6%   $	 150 6l   	 6<   �� *CheckInDate+
 �� StringFormat$
 d��6l     5      $ Check-out Date��6%   $	 150 6n   	 6=   �� *CheckOutDate+$
 d��6n     5      $ Total Price��6%   $	 120 6i   	 6:   �� *
TotalPrice+$
 C��6i   5      �� 5   
   -   5        $��	Dashboard��5      $
��Left=�6%   $��
717,11,0,0q�6@   $	��Top=�6T   $��32��6�   $��62��6�   ��5      �� 5       $ 0.5,1&�6&   $ 0.5,0&�67   .��5!      � $ Black��6#   � 5"      $ White��6#   $ 1Q�61   5#      5%      5'      5(      