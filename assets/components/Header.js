class Header extends HTMLElement {
    constructor() {
      super();
    }
  
    connectedCallback() {
      this.innerHTML = `
      <!-- Header -->
      <div id="header-wrapper">
          <header id="header" class="container">

              <!-- Logo -->
              <div id="logo">
                  <h1><a href="index.html">Lunar News Network</a></h1>
                  <span>presented by Sibelius</span>
              </div>

              <!-- Nav -->
              <nav id="nav">
                  <ul>
                      <li><a href="index.html">Willkommen!</a></li>
                      <li>
                          <a href="#">Artikelauswahl</a>
                          <ul>
                              <li><a href="forschungsstationverkauf.html">Mondstations-Verkauf</a></li>
                              <li><a href="japan-electronics.html">Japan-Lieferungsschwierigkeiten</a></li>
                              <li><a href="expansion.html">Mondhäfen-Expansion</a></li>
                              <li><a href="lunaris-skript.html">Lunaris-World-Skript</a></li>
                              <li><a href="story-skript.html">Lunaris-Story-Skript</a></li>
                          </ul>
                      </li>
                  </ul>
              </nav>
          </header>
      </div>
      `;
    }
  }
  
  customElements.define('header-component', Header);