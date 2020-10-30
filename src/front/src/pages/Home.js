import React from 'react'

function Home() {
  return (
    <div className='home'>
      <h1>
        Campanha de Natal JCC
      </h1>
      <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous" />
        <div className='content'>
          <p>
            Ajudando as pessoas a terem um Natal com mais esperança e amor!
        </p>
          <table className="table table-hover">
            <thead>
              <tr colspan="1" className="tabletitle">
                <th> Famílias Cadastradas </th>
                <a href="/families">
                  <strong>
                    Cadastre uma família
                </strong>
                </a>
              </tr>
              <tr className="linhas">
                <th className="lin1" scope="col">Família</th>
                <th scope="col"></th>
              </tr>
            </thead>
            <tbody>
              <tr className="registro">
                <th className="reg1" scope="row">Famíla A</th>
                <a className="edit" href="/families/edit">
                  <strong>
                    Editar
                </strong>
                </a>
              </tr>
            </tbody>
          </table>
        </div>
    </div>

  )
}

export default Home;
