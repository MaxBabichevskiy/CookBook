   M S B A M L   `   `   `  ����C  ?CookBook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:CookBook.ViewsCookBook.Views  5   	       CookBook.Views.RecipeView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:CookBook.Views     5   	     � Title$  
RecipeView��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��24(�6=   $
��Bold"�6K   $��10q�6]   ��6!   �� *
RecipeName+6]   �� 5   
   $��1��6   $��10q�6"   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��0,0,0,10q�62   .+�5      �� $��Тип блюда: ��6   $
��Bold"�6/   �� 5      ��6   �� *
RecipeType+5      �� 5      $ 
Horizontal=�6   $��0,0,0,10q�62   .+�5      �� $��Кухня: ��6   $
��Bold"�6+   �� 5      ��6   �� *	Cuisine+5      �� 5      $4��.Дополнительные свойства:��6   $
��Bold"�68   $��0,0,0,10q�6J   �� 5!      $ 
Horizontal=�6   $��0,0,0,5q�62   .+�5"      �� $��Сложность: ��6   $
��Bold"�6/   �� 5#      ��6   �� *
Difficulty+5$      �� 5&      $ 
Horizontal=�6   $��0,0,0,5q�62   .+�5'      �� $-��'Время приготовления: ��6   $
��Bold"�69   �� 5(      ��6   �� *PreparationTime+5)      �� 5,      $��Ингредиенты:��6   $
��Bold"�6,   $��0,0,0,10q�6>   �� 5.      ��6   �� *Ingredients+��5/      �� 50      .R�51      �� $ 
Horizontal=�6%   .+�52      �� ��6(   �� *Name+�� 53      $��, ��6(   �� 54      ��6(   �� *
Quantity+55      56      58      �� 5;      $*��$Шаги приготовления:��6   $
��Bold"�63   $��	0,10,0,10q�6E   �� 5=      ��6   �� *Steps+��5>      �� 5?      .R�5@      �� $ 
Horizontal=�6%   .+�5A      �� ��6(   �� *
StepNumber+�� 5B      $��. ��6(   �� 5C      ��6(   �� *Description+5D      5E      5G      5H      5I      5J      