   M S B A M L   `   `   `  ����L  HFolderTreeViewWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FolderTreeViewWPFFolderTreeViewWPF  5   	   "    FolderTreeViewWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:FolderTreeViewWPF     5   	     � Title$  Folder View��5   	   $	��800��6   $	��400��6*   .��5	      � .+�5
   
   R� -   5         R�Name$ 
folderView��5
      ��6'   �� *Items+��5      �� 5       �� 
TargetType" Q�6   .�5      ��  �� Property �@Q�
IsExpanded �� Value 63   �� *
IsExpanded+ �� Mode$ TwoWay=�5      ��5      �� 5       �� ItemsSource 6+   �� *
Children+.R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $��3q�6    $��20��6+   ��66   �� *Type+.   (FolderTreeViewWPF.HeaderToImageConverter   Instance	 �� 	Converter#	 Z �� 5      $��Center=�6$   ��6?   �� *Name+5      5      5      5      5      