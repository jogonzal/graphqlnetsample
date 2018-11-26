All of this work is based on:
https://fullstackmark.com/post/17/building-a-graphql-api-with-aspnet-core-2-and-entity-framework-core

This is a full working example of a GraphQL API and a sample client that uses it

## Querying all proveedores
```
{
  proveedores {
    proveedorClave
    proveedorNombre
  }
}
```

## Querying all cuentasgasto including provedoores
```
{
  cuentasgasto {
    cuentaGastoClave
    cuentaGastoDescripcion
    proveedores {
      proveedorClave
      proveedorNombre
    }
  }
}
```

## Adding an Agente

```
mutation ($agente: AgenteInputType!) {
  createAgente(agente: $agente) {
    agenteClave
    agenteNombre
  }
}
```

with query variables

```
{
  "agente": {
    "agenteClave": "8",
    "agenteNombre":  "5",
    "agenteDireccion": "5",
    "agenteCD_EDO_PAIS": "5",
    "agenteCP": "5",
    "agenteTelefono": "5",
    "agenteFax": "5",
    "agenteComision": 1.12,
    "agenteEstado": true
  }
}
```