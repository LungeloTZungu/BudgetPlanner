   M S B A M L   `   `   `  ����M  IWPF BUDGET PLANNER, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WPF_BUDGET_PLANNERWPF_BUDGET_PLANNER  5   	        WPF_BUDGET_PLANNER.Savings   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WPF_BUDGET_PLANNER     5   	     � Title$  Savings��5   	   $	��500��6   $	��800��6&   .��5	      � .+�5
   
   �� $��Center=�6   $��
0,0,-0.4,0q�61   $
��Wrap=�6E   $D��>                                 How much do you want to save ��6Y   $	��Top=�6�   $��65��6�   $	��794��6�   
��� ���$��23(�6�   $
��Bold"�6�   �� 5   
   $%��How much do you want to save ??��6   $
��Left=�6:   $��
10,104,0,0q�6U   $	��Top=�6i   $��15(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$
 txtA��5      $
��Left=�6    $��23��6;   $��
18,139,0,0q�6G    �� TextWrapping$
 Wrap=�6[   $�� ��6o   $	��Top=�6w   $	��120��6�   �� 5   
   $��What is the rate  ??��6   $
��Left=�6/   $��
10,201,0,0q�6J   $	��Top=�6^   $��15(�6v   $
��Bold"�6�   �� 5   
   -   5        $
 txtN��5      $
��Left=�6    $��23��6;   $��
18,336,0,0q�6G   $
 Wrap=�6[   $�� ��6o   $	��Top=�6w   $	��120��6�   �� 5   
   -   5        $
 txtR��5      $
��Left=�6    $��23��6;   $��
18,239,0,0q�6G   $
 Wrap=�6[   $�� ��6o   $	��Top=�6w   $	��120��6�   �� 5   
   $v��pHow often does interest get added ie: yearly = 12 , half-yearly = 6 and quarterly = 4  please put in the number ��6   $
��Left=�6�   $��
18,294,0,0q�6�   $	��Top=�6�   $
��Bold"�6�   $��14(�6�   �� 5   
   $5��/Over how many years would you like to save for ��6   $
��Left=�6J   $��
18,390,0,0q�6e   $	��Top=�6y    J� RenderTransformOrigin$ 1.115,0.855&�6�   $
��Bold"�6�   $��14(�6�   �� 5   
   -   5        $
 txtT��5      $
��Left=�6    $��23��6;   $��
18,433,0,0q�6G   $
 Wrap=�6[   $�� ��6o   $	��Top=�6w   $	��120��6�   �� 5   
   -   5         ��Name$ btnSaveValues��5      $
��Save��6(   $
��Left=�67   $��707,437,0,0q�6R   $	��Top=�6g   $��75��6   $
��Bold"�6�   6�   �� 5   
   -   5        $ 	btnGoback��5      $��Go Back��6$   $
��Left=�66   $��575,437,0,0q�6Q   $	��Top=�6f   $��75��6~   6�   	� 5   
   -   5         	�Name$ 	rdbCmpInt��5      $��Compund Interest ��6)   $
��Left=�6E   $��526,147,0,0q�6`   $	��Top=�6u   $
��Bold"�6�   $��14(�6�   	� 5   
   -   5        $ 	rdbSmpInt��5      $��Simple Interset��6)   $
��Left=�6C   $��526,189,0,0q�6^   $	��Top=�6s   $
��Bold"�6�   $��14(�6�   �� 5   
   $��Interest Option��6   $
��Left=�6*   $��546,104,0,0q�6E   $	��Top=�6Z   $��15(�6r   $
��Bold"�6�   5      5      