   M S B A M L   `   `   `  ����C  ?CookBook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CookBookCookBook  5   	       CookBook.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:CookBook     5   	     � Title$6  0Книга кулинарных рецептов��5   	   $	��450��6+   $	��800��68    � 	Resources 5	      +   %CookBook.BooleanToVisibilityConverter    BooleanToVisibilityConverter��%   &	          5
   
   6-   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��369* �6   �� 5      $	��31* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��10,10,10,10q�6.   $��2��6C   .+�5      �� $#��Добавить рецепт��6   $��10,10,10,10q�6/   ��6D   �� *AddRecipeCommand+�� 5      $#��Изменить рецепт��6   $��10,10,10,10q�6/   ��6D   �� *UpdateRecipeCommand+��6l   �� *SelectedRecipe+�� 5      $!��Удалить рецепт��6   $��10,10,10,10q�6.   ��6C   �� *DeleteRecipeCommand+��6k   �� *SelectedRecipe+5      �� 5!   
   $��1��6   $��10,10,10,10q�6g   $��2��6|   ��6   �� *	Recipes+ �� SelectedItem 6?   �� *SelectedRecipe+��5"      �� 5#      .R�5$      �� ��6    �� *Name+5%      5'      �� 5*   
   $��1��6   $��10,10,10,10q�6"   $��2��6�   y�67   �� *IsRecipeSelected+ �� 	Converter# [  .+�5+      �� $
��Bold"�6=   $��18(�6O   ��6   �� *SelectedRecipe.Name+6O   �� 5,      $	��0,5q�6@   ��6   �� *SelectedRecipe.Cuisine+6@   �� 5-      $	��0,5q�6=   ��6   �� *SelectedRecipe.Type+6=   �� 5.      $	��200��6?   $	��200��6K   $
��0,10q�6X   ��6   �� *SelectedRecipe.ImageUrl+6X   �� 5/      $
��Wrap=�6E   $
��0,10q�6Y   ��6   �� *SelectedRecipe.Instructions+6Y   50      �� 52   
   $��1��6   $��10,10,10,10q�6"   $��2��6�   y�67   �� *IsSearchVisible+# [  .+�53      �� $!��Поиск рецептов��6   $
��Bold"�6.   $��18(�6@   $��0,0,0,10q�6N   �� 56      $ 
Horizontal=�6   $	��0,5q�62   .+�57      �� $��Название:��6   $��Center=�6-   �� 58      -   5         ��Name$ txtSearchName��58      $	��200��61   $��30��6=   $��27,0,0,0q�6I   6[   59      �� 5<      $ 
Horizontal=�6   $	��0,5q�62   .+�5=      �� $��Ингредиенты:��6   $��Center=�60   �� 5>      -   5        $ txtSearchIngredients��5>      $	��200��68   $��30��6D   $��5,0,0,0q�6P   5?      �� 5B      $ 
Horizontal=�6   $	��0,5q�62   .+�5C      �� $��Кухня:��6   $��Center=�6*   �� 5D      -   5        $ txtSearchCuisine��5D      $	��200��64   $��30��6@   $��48,0,0,0q�6L   5E      �� 5G      -   5        $��
Поиск��5G      $
��0,10q�6A   5H      5I      5J      