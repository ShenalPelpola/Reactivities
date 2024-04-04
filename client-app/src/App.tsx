import { DuckItem } from "./DuckItem"
import { ducks } from "./demo"

function App() {
  return (
    <>
      <h1>Rectivities</h1>
      {
        ducks.map((duck) => (
          <DuckItem key={duck.name} duck={duck} />
        ))
      }
    </>
  )
}

export default App