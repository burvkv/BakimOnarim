using bakimonarim.business.Abstracts;
using bakimonarim.business.Concrete;
using bakimonarim.dataaccess.Concrete;

VarlikDal dal = new VarlikDal();
var data = dal.GetAll();
Console.WriteLine(data.Count);