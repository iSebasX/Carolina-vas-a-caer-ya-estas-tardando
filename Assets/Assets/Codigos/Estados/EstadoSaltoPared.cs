using UnityEngine;

public class EstadoSalto: Basestate
{
    public EstadoSalto(MovimientoStates controladorParametros) : base(controladorParametros) //Base se refiere a la clase padre
    {

    }
    public override void StateStart()
    {
        controlador.dongojo.Play("Jump");
        controlador.rigid.AddForce(Vector2.up * controlador.fuerzaSalto, ForceMode2D.Impulse);
    }
    public override void StateUpdate()
    {
        if(controlador.rigid.linearVelocity.y <= 0) 
        {
            if (controlador.tocandoPiso)
            {

                if (controlador.horizontal == 0)
                {
                    StateExit(controlador.idle);
                }
                else if (controlador.horizontal != 0)
                {
                    StateExit(controlador.correr);
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
        
        
    }
    public override void StateExit(Basestate newState)
    {
        controlador.CambiarEstado(newState);
    }
}
