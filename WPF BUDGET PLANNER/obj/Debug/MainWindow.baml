   M S B A M L   `   `   `  ����M  IWPF BUDGET PLANNER, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WPF_BUDGET_PLANNERWPF_BUDGET_PLANNER  5   	   #    WPF_BUDGET_PLANNER.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WPF_BUDGET_PLANNER     5   	     � Title$  
MainWindow��5   	   $	��439��6   $	��734��6)   .��5	      � .+�5
   
   �� $��Center=�6   $	��410��6-   $��-25,0q�6:   $	��Top=�6I   $	��778��6a   $+��%wp2128226-stock-market-wallpapers.jpg��6m   �� 5   
   $��BUDGET PLANNNER��6   $
��Left=�6*   $��
253,10,0,0q�6E   $	��Top=�6Y   $��23(�6q   
�������$��Oblique$�6�   �� 5   
   $��Gross Salary��6   $
��Left=�6'   $	��Top=�6B   $��	10,46,0,0q�6Z   
�������6m   �� 5   
   -   5         ��Name$ txtGrossSalary��5      $
��Left=�6*   $��23��6E   $��
101,50,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��120��6�   �� 5   
   $��Expenses��6   $
��Left=�6#   $��0,93,0,0q�6>   $	��Top=�6P    J� RenderTransformOrigin$ -3.995,0.039&�6h   
�������$��Italic$�6�   $��20(�6�   �� 5   
   $��	Groceries��6   $
��Left=�6$   $��
10,149,0,0q�6?   $	��Top=�6S   
�������6k   �� 5   
   $��Water and Electricity ��6   $
��Left=�61   $��
10,192,0,0q�6L   $	��Top=�6`   
�������6x   �� 5   
   $��Travel Cost��6   $
��Left=�6&   $��
10,248,0,0q�6A   $	��Top=�6U   $ -1.724,0.133&�6m   
�������6�   �� 5   
   $��Other��6   $
��Left=�6    $��
10,296,0,0q�6;   $	��Top=�6O   
�������6g   �� 5   
   -   5        $ txtGroceries��5      $
��Left=�6(   $��23��6C   $��180,149,0,0q�6O   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ txtW_E��5      $
��Left=�6"   $��23��6=   $��180,195,0,0q�6I   $
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��120��6�   �� 5   
   -   5        $ txtTravelCost��5      $
��Left=�6)   $��23��6D   $��180,252,0,0q�6P   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ txtOther��5      $
��Left=�6$   $��23��6?   $��180,300,0,0q�6K   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   �� 5   
   $-��'---------------------------------------��6   $
��Left=�6B   $��	0,118,0,0q�6]   $	��Top=�6p   
�������6�   �� 5   
   -   5         ��Name$ lblRent��5      $
��Rent��6!   $
��Left=�60   $��510,149,0,0q�6K   $	��Top=�6`   
�������6x   �� 5   
   -   5        $ txtRent��5      $
��Left=�6#   $��23��6>   $��555,149,0,0q�6J   $
 Wrap=�6_   $��0��6s   $	��Top=�6|   $	��120��6�   �� 5   
   -   5         ��Name$ 
txtHMonths��5      $��HomeLoan��6'   $
��Left=�69   $	��210��6T   $��510,180,0,0q�6a   $	��Top=�6v   $	��184��6�   $��15(�6�   $��Italic$�6�   
�������.��5      �� $
��Left=�6   $	��180��64   $��0,0,-2,0q�6A   $	��Top=�6S   $	��174��6k   .+�5      �� $��Purchase Price��6   
�������$��11(�6D   $��Normal$�6R   �� 5      -	   5        $ txtHPurchasePrice��5      $��19��65   $
 Wrap=�6A   $��0��6U   $��11(�6^   $��
0,0,-0.6,0q�6l   �� 5      $��Deposit��6   
�������$��11(�6=   $��Normal$�6K   �� 5      -
   5        $ txtHDeposit��5      $��19��6/   $
 Wrap=�6;   $��0��6O   $��11(�6X   $��
0,0,-0.6,0q�6f   �� 5       $��Interest��6   
�������$��11(�6>   $��Normal$�6L   �� 5!      -   5        $ txtHInterest��5!      $��19��60   $
 Wrap=�6<   $��0��6P   $��11(�6Y   $��
0,0,-0.6,0q�6g   $��Normal$�6{   �� 5"      $��Number of Months��6   
�������$��11(�6F   $��Normal$�6T   �� 5#      -   5        $ 
TxtHMonths��5#      $��19��6.   $
 Wrap=�6:   $��0��6N   $��11(�6W   $��Normal$�6e   5$      5%      �� 5&   
   -   5         ��Name$ btnAdd��5&      $��
Save Info ��6!   $
��Left=�66   $��239,380,0,0q�6Q   $	��Top=�6f   $��75��6~   $��Italic$�6�   $
��Bold"�6�   6�   �� 5'   
   $��	PhoneBill��6   $
��Left=�6$   $��
10,344,0,0q�6?   $	��Top=�6S   
�������6k   �� 5(   
   -   5        $ txtPhoneBill��5(      $
��Left=�6(   $��23��6C   $��180,347,0,0q�6O   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��120��6�   �� 5)   
   -   5        $ btnShowVehiclePage��5)      $��Show Vehicle Page��6-   $
��Left=�6I   $��
11,380,0,0q�6d   $	��Top=�6x   $	��106��6�   6�   �� 5*   
   -   5        $ btnShowResult��5*      $��Display��6(   $
��Left=�6:   $��378,380,0,0q�6U   $	��Top=�6j   $��75��6�   6�   	� 5+   
   -   5         	�Name$ rdbRent��5+      $��Rent ��6'   $
��Left=�67   $��
548,78,0,0q�6R   $	��Top=�6f   
�������6�   	� 5,   
   -   5        $ rdbPH��5,      $��Purchase House ��6%   $
��Left=�6?   $��
548,98,0,0q�6Z   $	��Top=�6n   
�������6�   �� 5-   
   $��Living Options��6   $
��Left=�6)   $��
555,47,0,0q�6D   $	��Top=�6X   
�������6p   53      54      