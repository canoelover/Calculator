using System;
using System.Text;

namespace Calculator
{
	public class Calculate
	{
		private string _expression;
		public string Expression {
			get{ return _expression; }
			set{ _expression = value; }
		}

		private string _lastsign;
		public string LastSign {
			get{ return _lastsign;}
			set{ _lastsign = value;}
		}

		private string _lastvalue;
		public string LastValue {
			get{ return _lastvalue;}
			set{ _lastvalue=value;}
		}

		private string _holdValue;
		public string HoldValue {
			get { return _holdValue; }
			set { _holdValue = value; }
		}

		private decimal _runningBal;
		public decimal RunningBal {
			get{ return _runningBal; }
			set{ _runningBal = value; }
		}

		/// <summary>
		/// This method takes button value and forms a string to be inserted in the expression label
		/// </summary>
		/// <param name="exp">Exp</param>
		/// <param name="addSpace">AddSpace</param>
		public void BuildExpression (string exp, bool addSpace)
		{
			int i = 0;
			decimal j = 0;
			bool isNumeric = false;


			if (addSpace) {
				Expression = Expression + " " + exp + " ";
			} else {
				Expression = Expression + exp;
			}

			i = 0;
			isNumeric  = int.TryParse(exp, out i); 

			if (isNumeric) {
				HoldValue = HoldValue + exp;
			} else {

				if (RunningBal == 0) {
					j = 0;
					isNumeric = decimal.TryParse (HoldValue, out j);
					if (isNumeric) {
						RunningBal = Convert.ToInt32 (HoldValue);
						LastSign = exp;
					} else {
						RunningBal = 0;
						LastSign = exp;
					}

				} else {
					
					switch (LastSign) {
					case "+":
						RunningBal = RunningBal + Convert.ToInt32 (HoldValue);
						break;
					case "-":
						RunningBal = RunningBal - Convert.ToInt32 (HoldValue);
						break;
					case "X":
						RunningBal = RunningBal * Convert.ToInt32 (HoldValue);
						break;
					case "/":
						RunningBal = RunningBal / Convert.ToInt32 (HoldValue);
						break;
					}					

					LastSign = exp;
				}
				HoldValue = "0";

			}
				
		}

		/// <summary>
		/// This method removes the last character in the expression
		/// </summary>
		public void Backspace ()
		{
			if (string.IsNullOrWhiteSpace (Expression)) {
				Expression = Expression;
			} else {
				if (Expression.Trim ().Length > 0) {
					Expression = Expression.Remove (Expression.Trim ().Length - 1);
				}
			}
		}

	}
}

