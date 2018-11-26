import * as React from 'react'

import './../assets/scss/App.scss'

import NavBar from './NavBar'
import { Link } from 'react-router-dom'
import { Button } from 'react-bootstrap'
import { ProveedoresApiClient, IProveedor } from '../api/ProveedoresApiClient'
type State = {
  proveedores: IProveedor[]
}

type Props = {
}

export default class HomePage extends React.Component<Props, State> {
  constructor(props) {
    super(props)
    this.state = { proveedores: [] }
  }

  componentDidMount() {
    this.updateProveedores()
  }

  async updateProveedores() {
    const proveedores = await ProveedoresApiClient.getProveedores()
    this.setState({
      proveedores
    })
  }

  addProveedor = () => {
    // TODO: implement in API, see Readme.md
  }

  render() {
    return (
      <div style={{minWidth: '500px'}}>
        <NavBar />
        <div className='container'>
        <Link to='/rcsoutdoor' >
            <Button className='btn-info'>RCS outdoor</Button>
        </Link>
        <br />
        <br />
        <Link to='/rcsindoor' >
            <Button className='btn-info'>RCS indoor</Button>
        </Link>
        </div>
        <Button onClick={this.addProveedor}></Button>

        {this.state.proveedores.map((proveedor, i) => {
          return (<div>
            Este es un proveedor: {proveedor.proveedorClave} - {proveedor.proveedorNombre}
          </div>)
        })}
      </div>
    )
  }
}