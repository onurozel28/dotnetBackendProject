using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{

    //Burada bu Interface'i  oluşturmamızın sebebi Entities'deki tabloları iş yapan classların
    //interface'i yoksa her zaman ama her zaman onun bir interface'ini oluşturmak gerek.
    //Sebebi 5-10 yıl sonra kullanabiliriz.
    //Bunu standart haline getir.Onu da Dal katmanında yapıyoruz.Data Access Layer(Veri Erişim Katmanı)
    //DataAccessLayer katmanında SQL işlemlerini halledeceğiz hep.Bu katman SQL katmanı gibi
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}
