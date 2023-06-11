import { StokAlani } from './StokAlani';

export interface AltParcaStok {
    id?: number;
    masraf: number;
    name: string;
    stokAlanis: StokAlani[];
}