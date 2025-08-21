import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'

function App() {
  const [count, setCount] = useState(0)

  return (
    <>
    <div>
      <div className='header'>
        <div className='header-menu'>
          <div className='header-menu-item'>
            <a href="#">Experience</a>
          </div>
          <div className='header-menu-item'>
            <a href="#">Skill</a>
          </div>
          <div className='header-menu-item'>
            <a href="#">Education</a>
          </div>
          <div className='header-menu-item'>
            <a href="#">Projects</a>
          </div>
          <div className='header-menu-item'>
            <a href="#">Testimonials</a>
          </div>
          <div className='header-menu-item'>
            <a href="#">Contact</a>
          </div>
        </div>
      </div>
      <div className='body'>
        <div className='container'>
          <div className='container-information'>
            <div className='container-information-avatar'>
              <img 
                src="https://via.placeholder.com/120x120/3275B4/FFFFFF?text=A" 
                alt="Alex Avatar" 
                //className="avatar-image"
              />
            </div>
            <div className='container-information-name'>
              Alex Johnson
            </div>
            <div className='container-information-title'>
              Senior Software Engineer | Building Scalable Web Solutions
            </div>
            <div className='container-information-contact'>
              <button className='container-information-primary'>
                <svg className="icon" viewBox="0 0 24 24">
                  <path d="M20 4H4c-1.1 0-1.99.9-1.99 2L2 18c0 1.1.9 2 2 2h16c1.1 0 2-.9 2-2V6c0-1.1-.9-2-2-2zm0 4l-8 5-8-5V6l8 5 8-5v2z"/>
                </svg>
                Email Me
              </button>
              <button className='container-information-secondary'>
                <svg className="icon" viewBox="0 0 24 24" fill="white" stroke="black" stroke-width="1.5">
                  <path d="M6.62 10.79c1.44 2.83 3.76 5.14 6.59 6.59l2.2-2.2c.27-.27.67-.36 1.02-.24 1.12.37 2.33.57 3.57.57.55 0 1 .45 1 1V20c0 .55-.45 1-1 1-9.39 0-17-7.61-17-17 0-.55.45-1 1-1h3.5c.55 0 1 .45 1 1 0 1.25.2 2.45.57 3.57.11.35.03.74-.25 1.02l-2.2 2.2z"/>
                </svg>
                Call Me
              </button>
            </div>
          </div>
          <div className='container-content'>
            <div className='container-content-header'>
              <span>About Me</span>
            </div>
            <div className='container-content-body'>
              <span>
                As a seasoned Senior Software Engineer with a passion for innovation and problem-solving, I specialize in crafting robust, high-performance web applications. My expertise spans full-stack development, with a strong emphasis on user experience and scalable architectures. I thrive in dynamic environments where I can leverage my skills to deliver impactful products and drive team success. I am always eager to learn new technologies and apply them to create efficient and elegant solutions.
              </span>
            </div>
          </div>
        </div>
        <div className='container-experience'>
          <div className='container-experience-header'>
            <span>Professional Experience</span>
          </div>
          <div className='container-experience-content'>
            <div className='container-experience-content-title'>
              <span>Senior Software Engineer</span>
            </div>
            <div className='container-experience-content-subtitle'>
              <span>Tech Innovations Inc., New York, NY | Jan 2021 – Present</span>
            </div>
            <div className='container-experience-content-detail'>
              <span>Led the development of a real-time data streaming platform, reducing data latency by 40% and improving analytics capabilities.</span>
            </div>
            <div className='container-experience-content-detail'>
              <span>Designed and implemented a microservices architecture for user authentication, enhancing security and system scalability.</span>
            </div>
            <div className='container-experience-content-detail'>
              <span>Mentored junior engineers, fostering a collaborative environment and improving code quality across the team.</span>
            </div>
          </div>

          
          <div className='container-experience-content'>
            <div className='container-experience-content-title'>
              <span>Software Engineer</span>
            </div>
            <div className='container-experience-content-subtitle'>
              <span>Data Solutions Corp., San Francisco, CA | Aug 2018 – Dec 2020</span>
            </div>
            <div className='container-experience-content-detail'>
              <span>Developed and maintained RESTful APIs for customer-facing applications, serving over 100,000 daily users.</span>
            </div>
            <div className='container-experience-content-detail'>
              <span>Contributed to the migration of legacy systems to modern cloud infrastructure (AWS), resulting in a 25% cost reduction.</span>
            </div>
            <div className='container-experience-content-detail'>
              <span>Implemented automated testing procedures, leading to a 15% decrease in reported bugs post-deployment.</span>
            </div>
          </div>
        </div>
      </div>

    </div>
    </>
  )
}

export default App
