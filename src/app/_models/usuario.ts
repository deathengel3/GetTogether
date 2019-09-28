import { Rol } from './rol';

export class Usuario {
    usuario: string;
    password: string;
    rol: Rol;
    token?: string;
}