   M S B A M L   `   `   `  ����?  ;Xpay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Final_GAD_CW2Final_GAD_CW2  5   	   "    Final_GAD_CW2.Customer_Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   'localclr-namespace:Final_GAD_CW2  5   	     � Title$  Customer_Login��5	   	   $	��600��6    $	��950��6-    � WindowStyle$
 None=�69    � 
ResizeMode$ NoResize=�6L    � WindowStartupLocation$ CenterScreen=�6b   ��5
      �� 5   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ Black��6    � Offset$ 0Q�6)   � 5      $ 	#FF1449FD��6   $ 1Q�6-   5      .��5      � ��5   
   �� 5      $ 0.5,1&�6"   $ 0.5,0&�63   .��5      � $ 	#FF1449FD��6   $ 0Q�61   � 5      $ 	#FF08D2FF��6   $ 1Q�61   5      .+�5   
   �� -   5        ���	#FF272D70$
��Left=�5   %   $	��518��6@   $	��Top=�6M   $	��950��6e   6q   '  !MaterialDesignThemes.Wpf.PackIcon  5   
      Kind$ Xamarin=�6"   $��58��61   $��61��6=   
�������$��	16,14,0,0q�6[   �� 5   
   $��Center=�6   $��333,78,354,0q�61   $
��Wrap=�6G   $	��Top=�6[   $��71��6s   $	��263��6   
�������$��36(�6�   �� 6�   $�Customer��6�   �� 6�   $� Login��6�   6�   �� 5   
   $
��Left=�6   $��152,154,0,0q�6/   $
��Wrap=�6D   $��	User Name��6X   $	��Top=�6i   $��57��6�   $	��220��6�   
�������$��24(�6�   �� 5   
   $
��Left=�6   $��151,299,0,0q�6/   $
��Wrap=�6D   $��Password��6X   $	��Top=�6h   $��46��6�   $	��180��6�   
�������$��24(�6�   d� 5   
   -   5        	 d�Name$	 
btn_toggle��5       *  &MaterialDesignSwitchAccentToggleButton#��[  5   	   
 � ToolTip$,
 &MaterialDesignSwitchAccentToggleButton��5    	    d� 	IsChecked$
 TrueY�5!   	   $��182,189,-401,-68q�6   
�������64   �� 5"   
   -   5         ��Name$ txt_customer_name��5"      $
��Left=�6-   $��55��6H   $��152,211,0,0q�6T    �� TextWrapping$
 Wrap=�6i   $	��Top=�6}   $	��629��6�   ���	#FFD3C8C8���	#FF1326EC$��20(�6�   ��6�   Z� 6�   G� 5#   
   -   5         G�Name$ txt_customer_psswd��5#      $
��Left=�62   $��152,349,0,0q�6M   $	��Top=�6b   $	��629��6z   ���	#FFD3C8C8$��51��6�   ���	#FF1326EC$��20(�6�   ��6�   Z� 6�   �� 5$   
   $
��Left=�6   $��620,415,0,0q�6/   $
��Wrap=�6D   $��Remember me��6X   $	��Top=�6k   
�������$��16(�6�   $��35��6�   $	��125��6�   �� 5&   
   -   5         ��Name$ btn_forgotpw��5&       % !MaterialDesignFlatSecondaryButton#��[ 5'   	   $
 MaterialDesignFlatButton��5(   	   $��Forgot Password��5)   	   $��123,407,631,153q�5*   ~   
�������$��16(�6�   $
��Auto��6�   {�6	   �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType$ WindowL�6�   �� 5,   
   -   5        $ 
btn_signin��5,       * &MaterialDesignFlatSecondaryMidBgButton#��[ 5-   	   $.
 (MaterialDesignFlatAccentBackgroundButton��5.   	   $��SIGN IN��5/   	   $��389,451,397,117q�50   ~   ���	#FF272D70���	#FF08D2FF{�6	   �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL���6�   Z� 6�   �� 51   
   -   5        $ btn_Register��51      #��[ 52      $
 MaterialDesignFlatButton��53      $��Register��54      $��611,525,179,43q�55   �   ���	#FF272D70$��16(�6�   {�6   �� *DataContext.ControlsEnabled+ �� *FindAncestor+" �6�   �� 56   
   $
��Left=�6   $��177,528,0,0q�6/   $
��Wrap=�6D   $G��ADon't you have an account please create an account Click Register��6X   $	��Top=�6�   
�������$��16(�6�   $��29��6�   57      58      