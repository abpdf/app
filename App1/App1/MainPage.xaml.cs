using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Security.Authentication.Identity.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace App1
{
	/// <summary>
	/// 可用于自身或导航至 Frame 内部的空白页。
	/// </summary>
	public sealed partial class MainPage : Page
	{
		public MainPage()
		{
			this.InitializeComponent();
		}
		decimal number1 = 0;
		decimal number2 = 0;
		decimal number3 = 0;
		bool finish = false;
		int order = 1;
		decimal bits = 1;
		bool decimal1 = false;
		bool decimal2 = false;
		int operator1;
		decimal result_number = 0;

		private void number_0(object sender, RoutedEventArgs e)
		{
			number3 = 0;
			if (order == 1)
			{
				if (finish == true)
				{
					number1 = 0;
					result_number = 0;
					bits = 1;
					decimal1 = false;
					decimal2 = false;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == false)
				{
					number1 = number1 * 10 + number3;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == true)
				{
					bits = bits * 10;
					number1 = number3 / bits+ number1;
					textblock1.Text = number1.ToString();
				}
			}
			if (order == 2)
			{
				if (finish == true)
				{
					number2 = 0;
					decimal2 = false;
					bits = 1;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == false)
				{
					number2 = number2 * 10 +number3;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == true)
				{
					bits = bits * 10;
					number2 = number2 / bits + number3;
					textblock1.Text = number2.ToString();
				}
			}
		}

		private void number_1(object sender, RoutedEventArgs e)
		{
			number3 = 1;
			if (order == 1)
			{
				if (finish == true)
				{
					number1 = 0;
					result_number = 0;
					bits = 1;
					decimal1 = false;
					decimal2 = false;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == false)
				{
					number1 = number1 * 10 + number3;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == true)
				{
					bits = bits * 10;
					number1 = number3 / bits + number1;
					textblock1.Text = number1.ToString();
				}
			}
			if (order == 2)
			{
				if (finish == true)
				{
					number2 = 0;
					decimal2 = false;
					bits = 1;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == false)
				{
					number2 = number2 * 10 + number3;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == true)
				{
					bits = bits * 10;
					number2 = number2 / bits + number3;
					textblock1.Text = number2.ToString();
				}
			}
		}

		private void number_2(object sender, RoutedEventArgs e)
		{
			number3 = 2;
			if (order == 1)
			{
				if (finish == true)
				{
					number1 = 0;
					result_number = 0;
					bits = 1;
					decimal1 = false;
					decimal2 = false;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == false)
				{
					number1 = number1 * 10 + number3;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == true)
				{
					bits = bits * 10;
					number1 = number3 / bits + number1;
					textblock1.Text = number1.ToString();
				}
			}
			if (order == 2)
			{
				if (finish == true)
				{
					number2 = 0;
					decimal2 = false;
					bits = 1;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == false)
				{
					number2 = number2 * 10 + number3;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == true)
				{
					bits = bits * 10;
					number2 = number2 / bits + number3;
					textblock1.Text = number2.ToString();
				}
			}
		}

		private void number_3(object sender, RoutedEventArgs e)
		{
			number3 = 3;
			if (order == 1)
			{
				if (finish == true)
				{
					number1 = 0;
					result_number = 0;
					bits = 1;
					decimal1 = false;
					decimal2 = false;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == false)
				{
					number1 = number1 * 10 + number3;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == true)
				{
					bits = bits * 10;
					number1 = number3 / bits + number1;
					textblock1.Text = number1.ToString();
				}
			}
			if (order == 2)
			{
				if (finish == true)
				{
					number2 = 0;
					decimal2 = false;
					bits = 1;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == false)
				{
					number2 = number2 * 10 + number3;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == true)
				{
					bits = bits * 10;
					number2 = number2 / bits + number3;
					textblock1.Text = number2.ToString();
				}
			}
		}

		private void number_4(object sender, RoutedEventArgs e)
		{
			number3 = 4;
			if (order == 1)
			{
				if (finish == true)
				{
					number1 = 0;
					result_number = 0;
					bits = 1;
					decimal1 = false;
					decimal2 = false;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == false)
				{
					number1 = number1 * 10 + number3;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == true)
				{
					bits = bits * 10;
					number1 = number3 / bits + number1;
					textblock1.Text = number1.ToString();
				}
			}
			if (order == 2)
			{
				if (finish == true)
				{
					number2 = 0;
					decimal2 = false;
					bits = 1;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == false)
				{
					number2 = number2 * 10 + number3;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == true)
				{
					bits = bits * 10;
					number2 = number2 / bits + number3;
					textblock1.Text = number2.ToString();
				}
			}
		}

		private void number_5(object sender, RoutedEventArgs e)
		{
			number3 =5;
			if (order == 1)
			{
				if (finish == true)
				{
					number1 = 0;
					result_number = 0;
					bits = 1;
					decimal1 = false;
					decimal2 = false;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == false)
				{
					number1 = number1 * 10 + number3;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == true)
				{
					bits = bits * 10;
					number1 = number3 / bits + number1;
					textblock1.Text = number1.ToString();
				}
			}
			if (order == 2)
			{
				if (finish == true)
				{
					number2 = 0;
					decimal2 = false;
					bits = 1;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == false)
				{
					number2 = number2 * 10 + number3;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == true)
				{
					bits = bits * 10;
					number2 = number2 / bits + number3;
					textblock1.Text = number2.ToString();
				}
			}
		}

		private void number_6(object sender, RoutedEventArgs e)
		{
			number3 = 6;
			if (order == 1)
			{
				if (finish == true)
				{
					number1 = 0;
					result_number = 0;
					bits = 1;
					decimal1 = false;
					decimal2 = false;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == false)
				{
					number1 = number1 * 10 + number3;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == true)
				{
					bits = bits * 10;
					number1 = number3 / bits + number1;
					textblock1.Text = number1.ToString();
				}
			}
			if (order == 2)
			{
				if (finish == true)
				{
					number2 = 0;
					decimal2 = false;
					bits = 1;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == false)
				{
					number2 = number2 * 10 + number3;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == true)
				{
					bits = bits * 10;
					number2 = number2 / bits + number3;
					textblock1.Text = number2.ToString();
				}
			}
		}

		private void number_7(object sender, RoutedEventArgs e)
		{
			number3 =7;
			if (order == 1)
			{
				if (finish == true)
				{
					number1 = 0;
					result_number = 0;
					bits = 1;
					decimal1 = false;
					decimal2 = false;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == false)
				{
					number1 = number1 * 10 + number3;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == true)
				{
					bits = bits * 10;
					number1 = number3 / bits + number1;
					textblock1.Text = number1.ToString();
				}
			}
			if (order == 2)
			{
				if (finish == true)
				{
					number2 = 0;
					decimal2 = false;
					bits = 1;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == false)
				{
					number2 = number2 * 10 + number3;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == true)
				{
					bits = bits * 10;
					number2 = number2 / bits + number3;
					textblock1.Text = number2.ToString();
				}
			}
		}

		private void number_8(object sender, RoutedEventArgs e)
		{
			number3 = 8;
			if (order == 1)
			{
				if (finish == true)
				{
					number1 = 0;
					result_number = 0;
					bits = 1;
					decimal1 = false;
					decimal2 = false;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == false)
				{
					number1 = number1 * 10 + number3;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == true)
				{
					bits = bits * 10;
					number1 = number3 / bits + number1;
					textblock1.Text = number1.ToString();
				}
			}
			if (order == 2)
			{
				if (finish == true)
				{
					number2 = 0;
					decimal2 = false;
					bits = 1;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == false)
				{
					number2 = number2 * 10 + number3;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == true)
				{
					bits = bits * 10;
					number2 = number2 / bits + number3;
					textblock1.Text = number2.ToString();
				}
			}
		}

		private void number_9(object sender, RoutedEventArgs e)
		{
			number3 = 9;
			if (order == 1)
			{
				if (finish == true)
				{
					number1 = 0;
					result_number = 0;
					bits = 1;
					decimal1 = false;
					decimal2 = false;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == false)
				{
					number1 = number1 * 10 + number3;
					textblock1.Text = number1.ToString();
				}
				if (decimal1 == true)
				{
					bits = bits * 10;
					number1 = number3 / bits + number1;
					textblock1.Text = number1.ToString();
				}
			}
			if (order == 2)
			{
				if (finish == true)
				{
					number2 = 0;
					decimal2 = false;
					bits = 1;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == false)
				{
					number2 = number2 * 10 + number3;
					textblock1.Text = number2.ToString();
				}
				if (decimal2 == true)
				{
					bits = bits * 10;
					number2 = number2 / bits + number3;
					textblock1.Text = number2.ToString();
				}
			}
		}

		private void c_button(object sender, RoutedEventArgs e)
		{
			number1 = 0;
			number2 = 0;
			decimal1 = false;
			decimal2 = false;
			bits = 1;
			finish = false;
			textblock1.Text = number1.ToString();
			order = 1;
			operator1 = 0;
			result_number = 0;
		}

		private void ce_button(object sender, RoutedEventArgs e)
		{
			if (order == 1)
			{
				number1 = 0;
				decimal1 = false;
				finish = false;
				bits = 1;
				textblock1.Text = number1.ToString();
			}
			if (order == 2)
			{
				number2 = 0;
				decimal2 = false;
				finish = false;
				bits = 1; textblock1.Text = number2.ToString();
			}
		}

		private void percent_button(object sender, RoutedEventArgs e)
		{
			if (order == 1)
			{
				number1 = number1 / 100;
				textblock1.Text = number1.ToString();
			}
			if (order == 2)
			{
				number2 = number2 / 100;
				textblock1.Text = number2.ToString();
			}
		}

		private void division_button(object sender, RoutedEventArgs e)
		{
			
		}

		private void multiplication_button(object sender, RoutedEventArgs e)
		{

		}

		private void subtraction_button(object sender, RoutedEventArgs e)
		{

		}

		private void addition_button(object sender, RoutedEventArgs e)
		{

		}

		private void equal_button(object sender, RoutedEventArgs e)
		{

		}

		private void square_button(object sender, RoutedEventArgs e)
		{

		}

		private void square_root_button(object sender, RoutedEventArgs e)
		{

		}

		private void reciprocal_button(object sender, RoutedEventArgs e)
		{

		}

		private void decimal_point_button(object sender, RoutedEventArgs e)
		{
			if (order == 1)
			{
				decimal1 = true;
			}
			if (order == 2)
			{
				decimal2 = true;
			}
		}
	}
}
