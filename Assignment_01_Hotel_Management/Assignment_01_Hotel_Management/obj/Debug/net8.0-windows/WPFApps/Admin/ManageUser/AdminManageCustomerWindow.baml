   M S B A M L   `   `   `  ����Y  UAssignment_01_Hotel_Management, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:Assignment_01_Hotel_Management.WPFApps&Assignment_01_Hotel_Management.WPFApps  5   	   F    @Assignment_01_Hotel_Management.WPFApps.AdminManageCustomerWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:Assignment_01_Hotel_Management.WPFApps     5   	     � Title$  AdminManageCustomerWindow��5   	   $	��400��6+   $	��800��68   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 1Q�6-   � 5      $ 	#FF3A53A0��6   $ 0Q�61   5      .+�5   
   �� -   5        $��SearchTextBox��5      $	��200��6'   $��30��63   $	��Top=�6?   $��
50,20,50,0q�6W   �� 5   
   -   5        $��Search��5      $	��100��6"   $��30��6.   $	��Top=�6:   $��300,20,50,0q�6R   6g   &   System.Windows.Controls.DataGrid  5   
   -   5        $��CustomerDataGrid��5      $	��229��6+   $	��Top=�68   $��
50,60,91,0q�6P      AutoGenerateColumns$ False��5         SelectionMode$ Single=�6/      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 50 6P   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   �� *
CustomerID+6P     5      $ 	Full Name��6%   $		 150 6]   
 68   �� *CustomerFullName+6]     5      $ Email��6%   $		 150 6U   
 64   �� *EmailAddress+6U     5      $ 	Telephone��6%   $		 150 6V   
 68   �� *	Telephone+6V     5      $ Birthday��6%   $		 150 6\   
 67   �� *CustomerBirthday+6\   5      �� 5   
   -   5        $��Add New Customer��5      $��30��6,   $	��Top=�68   $��121,307,551,0q�6P   6g   �� 5   
   -   5        $��Edit Customer��5      $��30��6)   $	��Top=�65   $��300,307,368,0q�6M   6d   �� 5    
   -   5        $��Delete Customer��5       $��30��6+   $	��Top=�67   $��475,307,193,0q�6O    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5!      V� 5"      .~�5#      �� �� 5$      �� 5%       �� Angle$ 0.231Q�6&   T� 5&      5'      5)      �� 5*   
   $��CUSTOMER MANAGEMENT��6   $
��Left=�6.   $��	50,22,0,0q�6I   $	��Top=�6\   $ -0.411,0.063&�6t   $
��Bold"�6�   �� 5,   
   -   5        $��	Dashboard��5,      $
��Left=�6%   $��
676,20,0,0q�6@   $	��Top=�6T   $��27��6�   $��82��6�   5.      5/      