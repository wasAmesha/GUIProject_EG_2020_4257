   M S B A M L   `   `   `  ����O  KProject_EG_2020_4257, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Project_EG_2020_4257Project_EG_2020_4257  5   	   (    "Project_EG_2020_4257.AddUserWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Project_EG_2020_4257     5   	     � WindowStartupLocation$  CenterScreen=�5       � WindowStyle$
 None=�6?    � AllowsTransparency$
 True��6R   
������ $	��500��5   E   $	��800��6R    � Title 6	   �� *Title+ �� UpdateSourceTrigger$ PropertyChanged=� � DataContext 5
      $   Project_EG_2020_4257.AddUserVM  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��2* �6   .+�5   
   �� -   5        $��/Model/Images/close2.png��5      $��1��62    K� ZIndex$ 1��6B      
imageClose#��[  6o   �� 5   
    �� CornerRadius$ 	10 0 0 10��6   ��5      �� 5      	 �� 
StartPoint$		 0,0&�6&   
 �� EndPoint$	
 1,1&�67   .��5      �  � Color$ #ffd500��6#    � Offset$ 0Q�63   � 5      $ 	#FFEDC706��6#   $ 1Q�65   5      ._�5      � .+�5       �� .+�5!      �  � Points �    -1��� ;X�����	#FFF3D53F6;   �� 5#      	 �� X1$	 266��6   	 �� Y1$	 320��6$   	 �� X2$	 120��6-   	 �� Y2$	 500��66   ���	#FFF3D53F$��2��6R   �� 5$      $	 266��6   $	 400��6$   $ 50��6-   $	 500��65   ���	#FFF3D53F$��2��6Q   �� 5%      $ 0��6   $	 420��6"   $	 230��6+   $	 500��64   ���	#FFF3D53F$��2��6P   5&      �� 5(      $��Center=�6   .+�5)      ��   addTitleText#��[ 6[   ��6    �� *Title+$ PropertyChanged=�6[   �� 5*       J� Opacity$	 0.8Q�6\   $��20 30q�6j     addNormalText#��[ 6y   ��6    �� *Detail+$ PropertyChanged=�6y   �� 5+      $��/Model/Images/arrow3.png��6     
imageArrow#��[ 6>   5,      5-      5.      �� 51   
   
�������$��1��6$   $ 	0 10 10 0��64   ._�52      �� $��Center=�6    �� Orientation$ Vertical=�64   .+�55      �� -   5         ��Name$ selected_Image��55      $��60��60   $	��100��6<   $��Center=�6H   $��0 0 0 10q�6�   ��6e   �� *SelectedImage+$ PropertyChanged=�6�   �� 57      $ 
Horizontal=�6   .+�58      �� $��
First Name��6      addText#��[ 62   �� 59      -   5         ��Name$ firstName_txt��59        
addTextBox#��[ 6u   
 � Tag$ 
First Name��6�   ��65   �� *	Firstname+$ PropertyChanged=�6�   5:      �� 5<      $ 
Horizontal=�6   .+�5=      �� $��	Last Name��6    #��[ 61   �� 5>      -   5        $ lastName_txt��5>      #��[ 6s   $ 	Last Name��6�   ��64   �� *
Lastname+$ PropertyChanged=�6�   5?      �� 5A      $ 
Horizontal=�6   .+�5B      �� $	��Age��6    #��[ 6+   �� 5C      -   5        $ age_txt��5C      #��[ 6i   $ 0��6�   ��6/   �� *Age+$ PropertyChanged=�6�   5D      �� 5F      $ 
Horizontal=�6   .+�5G      �� $��Date Of Birth��6    #��[ 65   �� 5H      -   5        $ dob_txt��5H      #��[ 6q   $ 
DD/MM/YYYY��6�   ��6/   �� *Dateofbirth+$ PropertyChanged=�6�   5I      �� 5K      $ 
Horizontal=�6   .+�5L      �� $	��GPA��6    #��[ 6+   �� 5M      -   5        $ gpa_txt��5M      #��[ 6i   $ 0��6�   ��6/   �� *Gpa+$ PropertyChanged=�6�   5N      �� 5P      $ 
Horizontal=�6   .+�5Q      �� $��Insert Profile Photo: ��6    #��[ 6>   $	��150��6_   �� 5R      $��Choose Image��6     addPhotoButton#��[ 6[   ��64   �� *UploadPhotoCommand+6[   5S      �� 5W      $��0 40 0 0q�6   $ 
Horizontal=�6/   $��Center=�6H   $��Center=�6c   .+�5X      �� $
��Save��6     addMainButton#��[ 6L   ��6,   �� *SaveCommand+6L   �� 5Y      $��Clear��6   #��[ 6N   ��6-   �� *ClearCommand+6N   5[      5^      5_      5`      5a      