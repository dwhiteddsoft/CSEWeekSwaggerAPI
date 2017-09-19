using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestSwaggerAPI.Models;

namespace TestSwaggerAPI.Controllers
{
	[Route("api/[controller]")] 	public class CarsController : Controller 	{ 		private List<Car> _lstCars = null;  		public CarsController() 		{ 			if (_lstCars == null) 			{ 				_lstCars = new List<Car>() 				{ 					new Car() { ID = 1, Make = "Ford", Model = "Mustang", Year = 1969, Color = "Red" }, 					new Car() { ID = 2, Make = "Chevy", Model = "Camaro", Year = 1969, Color = "Blue" }, 					new Car() { ID = 3, Make = "Ford", Model = "Coronet", Year = 1965, Color = "Light Blue" }, 					new Car() { ID = 4, Make = "Dodge", Model = "Challenger", Year = 1971, Color = "Yellow" }, 					new Car() { ID = 5, Make = "Mercedes", Model = "C130", Year = 2007, Color = "Black" } 				}; 			} 		}
		// GET api/cars
		[HttpGet] 		public IEnumerable<Car> Get() 		{ 			return _lstCars; 		}

		// GET api/cars/5
		[HttpGet("{id}")] 		public Car Get(int id) 		{ 			if (_lstCars.Select(x => x.ID == id).Count() != 1) 				return null;  			return _lstCars.Where(x => x.ID == id).ElementAt(0); 		}

		// POST api/values
		[HttpPost] 		public int Post([FromBody]CarUpdate value) 		{ 			Car newCar = new Car(_lstCars.Count() + 1, value); 			_lstCars.Add(newCar); 			return newCar.ID; 		}

		// PUT api/values/5
		[HttpPut("{id}")] 		public bool Put(int id, [FromBody]CarUpdate value) 		{ 			if (_lstCars.Select(x => x.ID == id).Count() != 1) 				return false; 			Car newCar = new Car(id, value); 			Car oldCar = _lstCars.Where(x => x.ID == id).ElementAt(0); 			oldCar.Make = newCar.Make; 			oldCar.Model = newCar.Model; 			oldCar.Year = newCar.Year; 			oldCar.Color = newCar.Color; 			return true; 		}

		// DELETE api/values/5
		[HttpDelete("{id}")] 		public bool Delete(int id) 		{ 			int idx = _lstCars.FindIndex(x => x.ID == id);
			if (idx < 0) 				return false; 			_lstCars.RemoveAt(idx); 			return true; 		} 	}
}
