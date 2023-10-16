using Microsoft.AspNetCore.Mvc;
namespace PortafolioI.Controllers;
public class PrincipalController : Controller{
  [HttpGet("")]
  public string Index(){
    return "Esta es mi página Index!!";
  }

  [HttpGet("proyectos")]
  public string Proyectos(){
    return "Estos son mis Proyectos!!";
  }

  [HttpGet("contacto")]
  public string Contacto(){
    return "Aquí puedes contactarme!!";
  }
}