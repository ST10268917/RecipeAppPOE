   M S B A M L   `   `   `  ����D  @RecipeApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:RecipeApp	RecipeApp  5   	   !    RecipeApp.IngredientDetails   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:RecipeApp     5   	     � Title$  IngredientDetails��5
   	   $	��464��6#   $	��800��60   .��5      � $	��418��6   $	��Top=�6    � RowDefinitions 5   
   �� 5      $
��399* �6   �� 5      $	��61* �6   .+�5   
   �� -   5         ��Name$ 
titleLabel��5      $��Ingredient Details��6$   $
��Left=�6A   $��	66,24,0,0q�6\   $	��Top=�6o   $��22(�6�   $
��Bold"�6�   $��Segoe UI Black)�6�   �� 5   
   -   5         ��Name$ unitOfMeasurementTB��5      $
��Left=�6/   $��200,195,0,0q�6J    �� TextWrapping$
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��120��6�   �� 5   
   $��Unit of measurement:��6   $
��Left=�6/   $��
66,191,0,0q�6J   $	��Top=�6^   �� 5   
   -   5        $ 
caloriesTB��5      $
��Left=�6&   $��140,240,0,0q�6A   $
 Wrap=�6V   $�� ��6j   $	��Top=�6r   $	��120��6�   �� 5   
   $��	Calories:��6   $
��Left=�6$   $��
66,236,0,0q�6?   $	��Top=�6S   �� 5   
   -   5        $ nameTB��5      $
��Left=�6"   $��
140,99,0,0q�6=   $
 Wrap=�6Q   $�� ��6e   $	��Top=�6m   $	��120��6�   �� 5   
   $��Name:��6   $
��Left=�6    $��	66,91,0,0q�6;   $	��Top=�6N   �� 5   
   -   5        $ 
quantityTB��5      $
��Left=�6&   $��140,144,0,0q�6A   $
 Wrap=�6V   $�� ��6j   $	��Top=�6r   $	��120��6�   �� 5   
   $��	Quantity:��6   $
��Left=�6$   $��
66,140,0,0q�6?   $	��Top=�6S   �� 5   
   $��Food Group:��6   $
��Left=�6&   $��
66,283,0,0q�6A   $	��Top=�6U   �� 5   
   -   5         ��Name$ foodGroupCB��5      $
��Left=�6(   $��168,283,0,0q�6C   $	��Top=�6X   $	��120��6p   5      �� 5   
   -   5         ��Name$ foodGroupDescr��5      $
��Left=�6,   $��37��6G   $��
70,328,0,0q�6S   $
��Wrap=�6g   $��	TextBlock��6{   $	��Top=�6�   $	��444��6�   �� 5   
   -   5         ��Name$ submitButton��5      $��Submit��6'   $
��Left=�68   $��
74,387,0,0q�6S   $	��Top=�6g   $��55��6   $��2��6�   5      5       