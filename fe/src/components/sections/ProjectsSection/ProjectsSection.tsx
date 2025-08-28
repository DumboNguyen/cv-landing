import React from 'react';
import Card from '../../common/Card/Card';
import { projectsData } from '../../../data';
import './ProjectsSection.css';

const ProjectsSection: React.FC = () => {
  return (
    <div className="container-featured-project">
      <div className="container-featured-project-header">
        <span>Featured Projects</span>
      </div>
      <div className="container-featured-project-content">
        {projectsData.map((project) => (
          <Card key={project.id} className="container-featured-project-card" hoverable>
            <div className="container-featured-project-card-title">
              <img 
                className="container-featured-project-content-img" 
                src={project.image} 
                alt={project.title}
              />
              <div className="container-featured-project-content-title">
                <span>{project.title}</span>
              </div>
            </div>
            <div className="container-featured-project-card-description">
              <span>{project.description}</span>
            </div>
            <div className="container-featured-project-card-technology">
              {project.technologies.map((tech, index) => (
                <div key={index} className="container-featured-project-card-technology-item">
                  <span>{tech}</span>
                </div>
              ))}
            </div>
          </Card>
        ))}
      </div>
    </div>
  );
};

export default ProjectsSection;
