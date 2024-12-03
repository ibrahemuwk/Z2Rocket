using Microsoft.AspNetCore.Mvc;

namespace RocketAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    //[Route("api/[controller]")]
    [ApiController]
    public class RocketController : Controller
    {
        public RocketController()
        {

        }

        [HttpGet]
        public ActionResult<RocketModel> GetRocketLunchingMessage()
        {
            
            string Message =  "Today marks an extraordinary moment in the history of space exploration as we prepare for the launch of Z2Rocket, " +
                "a symbol of human ingenuity, ambition, and the relentless pursuit of discovery. " +
                "At this very moment, we stand on the threshold of new frontiers, " +
                "eager to break through the boundaries of our world and reach for the stars.\r\n\r\n" +
                "The mission before us represents years of hard work, " +
                "dedication, and the collaboration of countless brilliant minds across science, " +
                "engineering, and technology. Every calculation, every test, every detail has been meticulously crafted to ensure success. " +
                "And as we count down to liftoff, we are reminded that every launch is not just about the rocket itself, " +
                "but about the dreams it carries—dreams of exploration, innovation, and a better future for all.\r\n\r\n" +
                "As we prepare to witness this historic event, let us pause and reflect on the enormity of what we are about to experience. " +
                "This rocket is not just a vehicle, but a bridge to new possibilities, " +
                "pushing the limits of what we know and exploring the vast unknown.\r\n\r\n" +
                "In just moments, we will send [Rocket Name] soaring into the sky. " +
                "The countdown is nearing its final seconds, and soon the roar of the engines will echo, " +
                "lifting us higher, reaching further, and bringing us closer to unlocking the mysteries of space.\r\n\r\n" +
                "Are you ready? Here we go, let’s make history together.\r\n\r\n" +
                "Five... Four... Three... Two... One... Lift-off!";

           return new RocketModel() { Message = Message , CurrentDate = DateTime.Now};
        }

        [HttpGet]
        public ActionResult<string> TestRunning()
        {
            return Ok("how are you?");
        }

    }

    public class RocketModel
    {
        public string Message { get; set; }

        public DateTime CurrentDate { get; set; }
    }
}
