   M S B A M L   `   `   `  ????B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.UserPageWin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   
   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        ? Title$  	Users App??5	   	   $	??350??6   $	??650??6(   .??5
      ? 
???????.+?5   
   ?? $	??400??6   $	??550??6    $??15q?6/   
???????$??Center=?6N    ?? Padding$ 30q?6i    ?? CornerRadius$ 20??6v    J? Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q?6#      Color$ 	LightGray??63      ShadowDepth$ 0Q?6E   ._?5      ?? .+?5      ?? $??User Cabinet??6   $??30(?60   $??DemiBold"?6>   $??	0 0  0 20q?6T   ? 5      $??0 0 0 20q?6   .+?5      ?? -   5        $
??Left=?5      $	??Add??6S    5        5      $ 	#FFBC9CFF??6/   5      ?? 5      -   5        $??Right=?5      $??Delete??6S    5        5      $ 	#FFBC9CFF??6/   5      5      ?? 5      -   5         ??Name$ listOfUsers??5      $??10q?60   ??5      ?? 5      .R?5       ? .+?5!   "   ?? $
??Bold"?6F   ??6,   ?? *
Fullname+6F   ?? 5"   "   $??, ??6,   $
??Bold"?66   ?? 5#   "   ??6,   ?? *Age+?? 5$   "   $??, ??6,   $
??Bold"?66   ?? 5%   "   ??6,   ?? *City+?? 5&   "   $??, ??6,   $
??Bold"?66   ?? 5'   "   ??6,   ?? *Salary+?? 5(   "   $??, ??6,   $
??Bold"?66   ?? 5)   "   ??6,   ?? *Email+5*      5+      5-      5.      5/      51      52      