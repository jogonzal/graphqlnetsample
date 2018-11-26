export interface IProveedor {
  proveedorClave: string
  proveedorNombre: string
}

export class ProveedoresApiClient {
  public static async getProveedores(): Promise<IProveedor[]> {
    const graphQLQuery = `{
      proveedores {
        proveedorClave
        proveedorNombre
      }
    }`
    const response = await fetch('/graphql', {
      method: 'POST',
      body: JSON.stringify({
        operationName: null,
        query: graphQLQuery,
        variables: null
      }),
      headers: {
        'Content-Type': 'application/json'
      }
    })
    const json = await response.json()
    return json.data.proveedores
  }
}