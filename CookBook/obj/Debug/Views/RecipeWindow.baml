   M S B A M L   `   `   `  ����C  ?CookBook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:CookBook.ViewsCookBook.Views  5   	   !    CookBook.Views.RecipeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:CookBook.Views     5   	     � Title$  RecipeWindow��5   	   $	��450��6   $	��600��6+   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��
Add Recipe��6   $
��Bold"�6&   $��18(�68   $��Center=�6F   $
��0,10q�6c   �� 5   
   $��1��6   $��20q�6"   .+�5      �� $��Recipe Name��6   $
��Bold"�6+   $��0,0,0,5q�6=   �� 5      -   5         ��Name$ txtRecipeName��5      $	��300��6-   $��30��69   $��0,0,0,10q�6E   �� 5      $��Category��6   $
��Bold"�6(   $��0,0,0,5q�6:   �� 5      -   5         ��Name$ cmbCategory��5      $	��300��6,   $��30��68   $��0,0,0,10q�6D   .@�5      �� $��	Breakfast��6   �� 5      $��Lunch��6   �� 5      $��Dinner��6   �� 5      $��Dessert��6   5      �� 5!      $��Ingredients��6   $
��Bold"�6+   $��0,0,0,5q�6=   �� 5"      -   5        $ txtIngredients��5"      $	��300��6.   $	��100��6:   $��0,0,0,10q�6G    �� TextWrapping$
 Wrap=�6Y   �� 5%      $��Instructions��6   $
��Bold"�6,   $��0,0,0,5q�6>   �� 5&      -   5        $ txtInstructions��5&      $	��300��6/   $	��150��6;   $��0,0,0,10q�6H   $
 Wrap=�6Z   �� 5)       �� Orientation$ 
Horizontal=�6   $��Center=�62   .+�5*      �� -   5        $	��Add��5*      $��80��6'   $��5q�62   6=   �� 5+      -   5        $��Cancel��5+      $��80��6*   $��5q�65   6@   5,      5-      5.      5/      