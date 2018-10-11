//
//  MasterViewController.m
//  IntengineMovieDatabase
//
//  Created by Sylwester Pilarz on 05/10/2018.
//  Copyright © 2018 Intengine. All rights reserved.
//

#import "MasterViewController.h"
#import "NSObject+IntengineMovieData.h"
#import "NSObject+IntengineMovieDoc.h"

@interface MasterViewController ()

@end

@implementation MasterViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do view setup here.
}

- (NSView *)tableView:(NSTableView *)tableView viewForTableColumn:(NSTableColumn *)tableColumn row:(NSInteger)row {
    NSTableCellView *cellView = [tableView makeViewWithIdentifier:tableColumn.identifier owner:self];
    
    if([tableColumn.identifier isEqualToString:@"MoviesColumn"]) {
        IntengineMovieDoc *movieDoc = [self.movies objectAtIndex:row];
        cellView.imageView.image = movieDoc.thumbImage;
        cellView.textField.stringValue = movieDoc.data.title;
        return cellView;
    }
    return cellView;
}

- (NSInteger)numberOfRowsInTableView:(NSTableView *)tableView {
    return [self.movies count];
}

@end
