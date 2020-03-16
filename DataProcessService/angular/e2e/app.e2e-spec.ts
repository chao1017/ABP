import { DataProcessTemplatePage } from './app.po';

describe('DataProcess App', function() {
  let page: DataProcessTemplatePage;

  beforeEach(() => {
    page = new DataProcessTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
