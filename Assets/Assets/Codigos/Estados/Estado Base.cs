public abstract class Basestate
{
    public Basestate(MovimientoStates controladorParametros) 
    {
        controlador = controladorParametros;
    }
    protected MovimientoStates controlador; // Protected es que se puede acceder a el desde todas las clases hijas
    public abstract void StateStart();
    public abstract void StateUpdate();
    public abstract void FixedUpdateState();
    public abstract void StateExit(Basestate newState);    
}
