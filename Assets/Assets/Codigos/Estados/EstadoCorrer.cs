using UnityEngine;

public class EstadoCorrer : Basestate
{
    public EstadoCorrer(MovimientoStates controladorParametros) : base(controladorParametros) //Base se refiere a la clase padre
    {

    }
    public override void StateStart()
    {
        controlador.dongojo.Play("Run");
           
    }
    public override void StateUpdate()
    {
        if (controlador.rigid.linearVelocity.y <= 0) 
        { 
            if (controlador.tocandoPiso)
            {
                if (Input.GetKeyDown(controlador.teclas))
                {
                    StateExit(controlador.salto);
                }
                else if (controlador.horizontal == 0)
                {
                    StateExit(controlador.idle);
                }
            }

            else
            {
                StateExit(controlador.caida);
            }
        }
    }
    public override void FixedUpdateState()
    {
        controlador.rigid.linearVelocity = new Vector2(controlador.horizontal* controlador.velocidad,controlador.rigid.linearVelocityY);
    }
    public override void StateExit(Basestate newState)
    {
        controlador.CambiarEstado(newState);
    }
}
