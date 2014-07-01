using System;
using Xamarin.Forms;

namespace StackLayoutTableViewBug
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new ContentPage { 
				Content = new StackLayout {
					Children = {
						new TableView {
							Root = new TableRoot {
								new TableSection {
									new ViewCell {
										View = new StackLayout {
											Children = {
												new Label {
													Text = "Blubb",
												},
											},
										},
									},
									new ViewCell {
										View = new StackLayout {
											Children = {
												new Label {
													Text = "Blubb",
												},
											},
										},
									},
									new ViewCell {
										View = new Label {
											Text = "Bla",
										},
									},
								},
							},
						},
					},
				},
			};
		}
	}
}

