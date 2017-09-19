using System;
using System.ComponentModel.DataAnnotations;

namespace TestSwaggerAPI.Models
{
	public class Car 	{ 		public Car() { } 		public Car(int id, CarUpdate car)
		{ 			ID = id; 			Make = car.Make; 			Model = car.Model; 			car.Year = car.Year; 			car.Color = car.Color; 		}  		private int _ID; 		public int ID 		{ 			get { return _ID; } 			set { _ID = value; } 		}  		private string _Make = ""; 		[Required] 		public string Make 		{ 			get { return _Make; } 			set { _Make = value; } 		}  		private string _Model = ""; 		[Required] 		public string Model 		{ 			get { return _Model; } 			set { _Model = value; } 		}  		private int _Year; 		[Required] 		public int Year 		{ 			get { return _Year; } 			set { _Year = value; } 		}  		private string _Color = ""; 		[Required] 		public string Color 		{ 			get { return _Color; } 			set { _Color = value; } 		}  	} 	public class CarUpdate 	{ 		private string _Make = ""; 		[Required] 		public string Make 		{ 			get { return _Make; } 			set { _Make = value; } 		}  		private string _Model = ""; 		[Required] 		public string Model 		{ 			get { return _Model; } 			set { _Model = value; } 		}  		private int _Year; 		[Required] 		public int Year 		{ 			get { return _Year; } 			set { _Year = value; } 		}  		private string _Color = ""; 		[Required] 		public string Color 		{ 			get { return _Color; } 			set { _Color = value; } 		}  	} }
